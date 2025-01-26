using System;
using System.ComponentModel;

namespace Cselian.Core
{
	public interface IThreadHelper
	{
		event EventHandler Completed;

		void Run();
	}

	/// <summary>
	/// Wraps a BackgroundWorker to do Work and provides a callback.
	/// </summary>
	public class ThreadHelper<TArgs, TResult> : IThreadHelper
	{
		private Func<TArgs, TResult> Work;

		private BackgroundWorker Worker;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="work">The work to be done (in another thread)</param>
		/// <param name="callback">The method to be called back when the work is complete</param>
		public ThreadHelper(Func<TArgs, TResult> work, TArgs args)
		{
			Work = work;
			Args = args;
			Worker = new BackgroundWorker();
			Worker.DoWork += new DoWorkEventHandler(Worker_DoWork);
			Worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Worker_RunWorkerCompleted);
		}

		public event EventHandler Completed;

		public TArgs Args { get; private set; }

		public TResult Result { get; private set; }

		public void Run()
		{
			Worker.RunWorkerAsync(Args);
		}

		private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (Completed != null)
			{
				Completed(this, EventArgs.Empty);
			}
		}

		private void Worker_DoWork(object sender, DoWorkEventArgs e)
		{
			Result = Work((TArgs)e.Argument);
		}
	}
}
