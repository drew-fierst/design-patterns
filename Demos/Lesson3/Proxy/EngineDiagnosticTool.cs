using System;
using System.Threading;

namespace Proxy
{
	public class EngineDiagnosticTool : IDiagnosticTool
	{
		public virtual void RunDiagnosis(object obj)
		{
			Console.WriteLine("Starting engine diagnostic tool for " + obj);
			//simulate a long-running process
			Thread.Sleep(5000);
			Console.WriteLine("Engine diagnosis complete");
		}

	}
}
