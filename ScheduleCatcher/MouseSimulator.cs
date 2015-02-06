using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace Cselian.ScheduleCatcher
{
	/// <summary>
	/// Defines values that specify the buttons on a mouse device.
	/// </summary>
	public enum MouseButton
	{
		/// <summary>
		/// The left mouse button.
		/// </summary>
		Left = 0,

		/// <summary>
		/// The middle mouse button.
		/// </summary>
		Middle = 1,

		/// <summary>
		/// The right mouse button.
		/// </summary>
		Right = 2,

		/// <summary>
		/// The first extended mouse button.
		/// </summary>
		XButton1 = 3,

		/// <summary>
		/// The second extended mouse button
		/// </summary>
		XButton2 = 4,
	}

	/// <summary>
	/// The state of the mouse button.
	/// </summary>
	internal enum MouseButtonState
	{
		Released = 0,
		Pressed = 1,
	}

	public class MouseSimulator
	{
		/// <summary>
		/// Clicks a mouse button.
		/// </summary>
		/// <param name="mouseButton">The mouse button to click.</param>
		public static void Click(MouseButton mouseButton)
		{
			Down(mouseButton);
			Up(mouseButton);
		}

		/// <summary>
		/// Moves the mouse pointer to the specified screen coordinates.
		/// </summary>
		/// <param name="point">The screen coordinates to move to.</param>
		public static void MoveTo(System.Drawing.Point point)
		{
			SendMouseInput(point.X, point.Y, 0, SendMouseInputFlags.Move | SendMouseInputFlags.Absolute);
		}

		/// <summary>
		/// Performs a mouse-up operation for a specified mouse button.
		/// </summary>
		/// <param name="mouseButton">The mouse button to use.</param>
		public static void Up(MouseButton mouseButton)
		{
			int additionalData;
			var inputFlags = GetInputFlags(mouseButton, true, out additionalData);
			SendMouseInput(0, 0, additionalData, inputFlags);
		}

		/// <summary>
		/// Performs a mouse-down operation for a specified mouse button.
		/// </summary>
		/// <param name="mouseButton">The mouse button to use.</param>
		public static void Down(MouseButton mouseButton)
		{
			int additionalData;
			var inputFlags = GetInputFlags(mouseButton, false, out additionalData);
			SendMouseInput(0, 0, additionalData, inputFlags);
		}

		/// <summary>
		/// Sends mouse input.
		/// </summary>
		/// <param name="x">x coordinate</param>
		/// <param name="y">y coordinate</param>
		/// <param name="data">scroll wheel amount</param>
		/// <param name="flags">SendMouseInputFlags flags</param>
		[PermissionSet(SecurityAction.Assert, Name = "FullTrust")]
		private static void SendMouseInput(int x, int y, int data, SendMouseInputFlags flags)
		{
			PermissionSet permissions = new PermissionSet(PermissionState.Unrestricted);
			permissions.Demand();

			uint intflags = (uint)flags;

			if ((intflags & (int)SendMouseInputFlags.Absolute) != 0)
			{
				// Absolute position requires normalized coordinates.
				NormalizeCoordinates(ref x, ref y);
				intflags |= NativeMethods.MouseeventfVirtualdesk;
			}

			var mi = new NativeMethods.INPUT();
			mi.Type = NativeMethods.INPUT_MOUSE;
			mi.Data.Mouse.dx = x;
			mi.Data.Mouse.dy = y;
			mi.Data.Mouse.mouseData = data;
			mi.Data.Mouse.dwFlags = intflags;
			mi.Data.Mouse.time = 0;
			mi.Data.Mouse.dwExtraInfo = new IntPtr(0);

			if (NativeMethods.SendInput(1, new NativeMethods.INPUT[] { mi }, Marshal.SizeOf(mi)) == 0)
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
		}

		private static SendMouseInputFlags GetInputFlags(MouseButton mouseButton, bool isUp, out int additionalData)
		{
			SendMouseInputFlags flags;
			additionalData = 0;

			if (mouseButton == MouseButton.Left && isUp)
			{
				flags = SendMouseInputFlags.LeftUp;
			}
			else if (mouseButton == MouseButton.Left && !isUp)
			{
				flags = SendMouseInputFlags.LeftDown;
			}
			else if (mouseButton == MouseButton.Right && isUp)
			{
				flags = SendMouseInputFlags.RightUp;
			}
			else if (mouseButton == MouseButton.Right && !isUp)
			{
				flags = SendMouseInputFlags.RightDown;
			}
			else if (mouseButton == MouseButton.Middle && isUp)
			{
				flags = SendMouseInputFlags.MiddleUp;
			}
			else if (mouseButton == MouseButton.Middle && !isUp)
			{
				flags = SendMouseInputFlags.MiddleDown;
			}
			else if (mouseButton == MouseButton.XButton1 && isUp)
			{
				flags = SendMouseInputFlags.XUp;
				additionalData = (int)NativeMethods.XBUTTON1;
			}
			else if (mouseButton == MouseButton.XButton1 && !isUp)
			{
				flags = SendMouseInputFlags.XDown;
				additionalData = (int)NativeMethods.XBUTTON1;
			}
			else if (mouseButton == MouseButton.XButton2 && isUp)
			{
				flags = SendMouseInputFlags.XUp;
				additionalData = (int)NativeMethods.XBUTTON2;
			}
			else if (mouseButton == MouseButton.XButton2 && !isUp)
			{
				flags = SendMouseInputFlags.XDown;
				additionalData = (int)NativeMethods.XBUTTON2;
			}
			else
			{
				throw new InvalidOperationException();
			}

			return flags;
		}

		private static void NormalizeCoordinates(ref int x, ref int y)
		{
			int vScreenWidth = NativeMethods.GetSystemMetrics(NativeMethods.SMCxvirtualscreen);
			int vScreenHeight = NativeMethods.GetSystemMetrics(NativeMethods.SMCyvirtualscreen);
			int vScreenLeft = NativeMethods.GetSystemMetrics(NativeMethods.SMXvirtualscreen);
			int vScreenTop = NativeMethods.GetSystemMetrics(NativeMethods.SMYvirtualscreen);

			// Absolute input requires that input is in 'normalized' coords - with the entire
			// desktop being (0,0)...(65536,65536). Need to convert input x,y coords to this
			// first.
			//
			// In this normalized world, any pixel on the screen corresponds to a block of values
			// of normalized coords - eg. on a 1024x768 screen,
			// y pixel 0 corresponds to range 0 to 85.333,
			// y pixel 1 corresponds to range 85.333 to 170.666,
			// y pixel 2 correpsonds to range 170.666 to 256 - and so on.
			// Doing basic scaling math - (x-top)*65536/Width - gets us the start of the range.
			// However, because int math is used, this can end up being rounded into the wrong
			// pixel. For example, if we wanted pixel 1, we'd get 85.333, but that comes out as
			// 85 as an int, which falls into pixel 0's range - and that's where the pointer goes.
			// To avoid this, we add on half-a-"screen pixel"'s worth of normalized coords - to
			// push us into the middle of any given pixel's range - that's the 65536/(Width*2)
			// part of the formula. So now pixel 1 maps to 85+42 = 127 - which is comfortably
			// in the middle of that pixel's block.
			// The key ting here is that unlike points in coordinate geometry, pixels take up
			// space, so are often better treated like rectangles - and if you want to target
			// a particular pixel, target its rectangle's midpoint, not its edge.
			x = ((x - vScreenLeft) * 65536) / vScreenWidth + 65536 / (vScreenWidth * 2);
			y = ((y - vScreenTop) * 65536) / vScreenHeight + 65536 / (vScreenHeight * 2);
		}

		private static MouseButtonState GetButtonState(MouseButton mouseButton)
		{
			var mouseButtonState = MouseButtonState.Released;

			int virtualKeyCode = 0;
			switch (mouseButton)
			{
				case MouseButton.Left:
					virtualKeyCode = NativeMethods.VK_LBUTTON;
					break;
				case MouseButton.Right:
					virtualKeyCode = NativeMethods.VK_RBUTTON;
					break;
				case MouseButton.Middle:
					virtualKeyCode = NativeMethods.VK_MBUTTON;
					break;
				case MouseButton.XButton1:
					virtualKeyCode = NativeMethods.VK_XBUTTON1;
					break;
				case MouseButton.XButton2:
					virtualKeyCode = NativeMethods.VK_XBUTTON2;
					break;
			}

			mouseButtonState = (NativeMethods.GetKeyState(virtualKeyCode) & 0x8000) != 0 ? MouseButtonState.Pressed : MouseButtonState.Released;
			return mouseButtonState;
		}
	}

	/// <summary>
	/// Mouse input flags used by the Native Input struct.
	/// </summary>
	[Flags]
	internal enum SendMouseInputFlags
	{
		Move = 0x0001,
		LeftDown = 0x0002,
		LeftUp = 0x0004,
		RightDown = 0x0008,
		RightUp = 0x0010,
		MiddleDown = 0x0020,
		MiddleUp = 0x0040,
		XDown = 0x0080,
		XUp = 0x0100,
		Wheel = 0x0800,
		Absolute = 0x8000,
	};

	internal static class NativeMethods
	{
		#region Const data

		private const string Gdi32Dll = "GDI32.dll";
		private const string User32Dll = "User32.dll";

		public const int INPUT_MOUSE = 0;
		public const int INPUT_KEYBOARD = 1;
		public const int INPUT_HARDWARE = 2;
		public const uint KEYEVENTF_EXTENDEDKEY = 0x0001;
		public const uint KEYEVENTF_KEYUP = 0x0002;
		public const uint KEYEVENTF_UNICODE = 0x0004;
		public const uint KEYEVENTF_SCANCODE = 0x0008;
		public const uint XBUTTON1 = 0x0001;
		public const uint XBUTTON2 = 0x0002;
		public const uint MOUSEEVENTF_MOVE = 0x0001;
		public const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
		public const uint MOUSEEVENTF_LEFTUP = 0x0004;
		public const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
		public const uint MOUSEEVENTF_RIGHTUP = 0x0010;
		public const uint MOUSEEVENTF_MIDDLEDOWN = 0x0020;
		public const uint MOUSEEVENTF_MIDDLEUP = 0x0040;
		public const uint MOUSEEVENTF_XDOWN = 0x0080;
		public const uint MOUSEEVENTF_XUP = 0x0100;
		public const uint MOUSEEVENTF_WHEEL = 0x0800;
		public const uint MOUSEEVENTF_VIRTUALDESK = 0x4000;
		public const uint MOUSEEVENTF_ABSOLUTE = 0x8000;

		public const int VKeyShiftMask = 0x0100;
		public const int VKeyCharMask = 0x00FF;

		public const int VK_LBUTTON = 0x0001;
		public const int VK_RBUTTON = 0x0002;
		public const int VK_MBUTTON = 0x0004;
		public const int VK_XBUTTON1 = 0x0005;
		public const int VK_XBUTTON2 = 0x0006;

		public const int SMXvirtualscreen = 76;
		public const int SMYvirtualscreen = 77;
		public const int SMCxvirtualscreen = 78;
		public const int SMCyvirtualscreen = 79;

		public const int MouseeventfVirtualdesk = 0x4000;
		public const int WheelDelta = 120;

		#endregion Const data

		#region Structs

		[StructLayout(LayoutKind.Sequential)]
		public struct MOUSEINPUT
		{
			public int dx;
			public int dy;
			public int mouseData;
			public uint dwFlags;
			public uint time;
			public IntPtr dwExtraInfo;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct KEYBDINPUT
		{
			public ushort wVk;
			public ushort wScan;
			public uint dwFlags;
			public uint time;
			public IntPtr dwExtraInfo;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct HARDWAREINPUT
		{
			public uint uMsg;
			public ushort wParamL;
			public ushort wParamH;
		}

		/// <summary>
		/// The INPUT structure is used by SendInput to store information for synthesizing input events such as keystrokes, mouse movement, and mouse clicks. (see: http://msdn.microsoft.com/en-us/library/ms646270(VS.85).aspx)
		/// Declared in Winuser.h, include Windows.h
		/// </summary>
		/// <remarks>
		/// This structure contains information identical to that used in the parameter list of the keybd_event or mouse_event function.
		/// Windows 2000/XP: INPUT_KEYBOARD supports nonkeyboard input methods, such as handwriting recognition or voice recognition, as if it were text input by using the KEYEVENTF_UNICODE flag. For more information, see the remarks section of KEYBDINPUT.
		/// </remarks>
		public struct INPUT
		{
			/// <summary>
			/// Specifies the type of the input event. This member can be one of the following values. 
			/// InputType.MOUSE - The event is a mouse event. Use the mi structure of the union.
			/// InputType.KEYBOARD - The event is a keyboard event. Use the ki structure of the union.
			/// InputType.HARDWARE - Windows 95/98/Me: The event is from input hardware other than a keyboard or mouse. Use the hi structure of the union.
			/// </summary>
			public UInt32 Type;

			/// <summary>
			/// The data structure that contains information about the simulated Mouse, Keyboard or Hardware event.
			/// </summary>
			public MOUSEKEYBDHARDWAREINPUT Data;
		}

		/// <summary>
		/// The combined/overlayed structure that includes Mouse, Keyboard and Hardware Input message data (see: http://msdn.microsoft.com/en-us/library/ms646270(VS.85).aspx)
		/// </summary>
		[StructLayout(LayoutKind.Explicit)]
		public struct MOUSEKEYBDHARDWAREINPUT
		{
			[FieldOffset(0)]
			public MOUSEINPUT Mouse;

			[FieldOffset(0)]
			public KEYBDINPUT Keyboard;

			[FieldOffset(0)]
			public HARDWAREINPUT Hardware;
		}

		#endregion Structs

		#region Methods

		[DllImport(User32Dll)]
		public static extern short GetKeyState(int nVirtKey);

		[DllImport(User32Dll, CharSet = CharSet.Auto)]
		public static extern short VkKeyScan(char ch);

		[DllImport(User32Dll, SetLastError = true)]
		public static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

		[DllImport(User32Dll, ExactSpelling = true, EntryPoint = "GetSystemMetrics", CharSet = CharSet.Auto)]
		public static extern int GetSystemMetrics(int nIndex);

		/// <summary>Converts the client-area coordinates of a specified point to screen coordinates.</summary>
		/// <param name="hwndFrom">Handle to the window whose client area is used for the conversion.</param>
		/// <param name="pt">POINT structure that contains the client coordinates to be converted.</param>
		/// <returns>true if the function succeeds, false otherwise.</returns>
		[DllImport("user32.dll", EntryPoint = "ClientToScreen", CharSet = CharSet.Auto)]
		public static extern bool ClientToScreen(IntPtr hwndFrom, [In, Out] ref System.Drawing.Point pt);

		#endregion Methods
	}
}
