Imports System
Imports System.IO

Public Class LyrMgr

	Public Shared Function Exists(ByVal p As String) As Boolean
		Return File.Exists(FileOf(p))
	End Function

	Public Shared Function Load(ByVal p As String) As Info
		Return New Info(FileOf(p))
	End Function

	Private Shared Function FileOf(ByVal p As String) As String
		Return p.Replace(Path.GetExtension(p), ".lrc")
	End Function

	Private Shared Function TimeOf(ByVal v As String) As Double
		'00:04.13
		Dim hms As String() = v.Split(":".ToCharArray())
		Dim h = 0 : If hms.Length > 2 Then h = Integer.Parse(hms(0)) * 3600
		Dim secs = Double.Parse(hms(hms.Length - 1)) + Integer.Parse(hms(hms.Length - 2)) * 60 + h
		Return secs
	End Function

	Public Class Info

		Private ReadOnly _lines As Line()

		Public Sub New(ByVal f As String)
			Dim list As New List(Of Line)
			Dim grp = 1
			Dim lines = File.ReadAllLines(f)

			For Each l As String In lines
				If String.IsNullOrEmpty(l) Then
					grp += 1
					Continue For
				End If

				list.Add(New Line(grp, l))
			Next

			_lines = list.ToArray
		End Sub

		Public ReadOnly Property Lines As Line()
			Get
				Return _lines
			End Get
		End Property

		Public Function Find(ByVal where As Double) As Line
			Dim ret As Line = Nothing
			For Each l As Line In _lines
				If (l.Start > where) Then
					Return ret
				End If
				ret = l
			Next
			Return Nothing
		End Function

		Public Function FindFirst(ByVal group As Integer) As Line
			For Each l As Line In _lines
				If (l.Group = group) Then
					Return l
				End If
			Next
			Return Nothing
		End Function

		Public Function Within(ByVal item As LyrMgr.Line, ByVal where As Double) As Boolean
			If item Is Nothing Then Return False
			If where < item.Start Then Return False
			Dim ix As Integer = Array.IndexOf(_lines, item)
			If ix = _lines.Length - 1 Then Return True
			Dim nxt As LyrMgr.Line = _lines(ix + 1)
			Return nxt.Start > where
		End Function

	End Class

	Public Class Line

		Private _grp As Integer
		Dim _start As Double
		Dim _txt, _startString As String

		Public Sub New(ByVal g As Integer, ByVal line As String)
			_grp = g
			If line.StartsWith("[") And line.Contains("]") Then
				Dim bits = line.Substring(1, line.Length - 1).Split("]".ToCharArray(), 2)
				_startString = bits(0)
				_start = TimeOf(bits(0))
				_txt = bits(1)
			Else
				_txt = line
			End If
		End Sub

		Public ReadOnly Property Group As Integer
			Get
				Return _grp
			End Get
		End Property

		Public ReadOnly Property DisplayText As String
			Get
				Return String.Format("[{0}  {2}] {1}", _startString, Text, _grp)
			End Get
		End Property

		Public ReadOnly Property Start As Double
			Get
				Return _start
			End Get
		End Property

		Public ReadOnly Property Text As String
			Get
				Return _txt
			End Get
		End Property

		Public Sub MoveStart(ByVal val As Double)
			_start = val
		End Sub

		Public Sub MoveBy(ByVal val As Double)
			_start = _start + val
		End Sub

	End Class

End Class
