using System;

namespace Proxy
{
	public class Client
	{
		static void Main()
		{
			Console.WriteLine();
			
			IEngine engine = new EngineProxy(1300, false);
			engine.Diagnose(new EngineDiagnosticTool());
			Console.ReadLine();
		}
	}
}
