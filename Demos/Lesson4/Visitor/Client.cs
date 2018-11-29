using System;

namespace Visitor
{
	public class Client
	{
		static void Main()
		{
			Console.WriteLine();

			Console.WriteLine("Working on a standard engine:");
			// Create an engine...
			IEngine engine = new StandardEngine(1300);
			// Run diagnostics on the engine...
			IEngineVisitor diag = new EngineDiagnostics();
			engine.AcceptEngineVisitor(diag);
			// Run inventory on the engine...
			IEngineVisitor inv = new EngineInventory();
			engine.AcceptEngineVisitor(inv);

			Console.WriteLine("-----------------------------");
			Console.WriteLine();

			Console.WriteLine("Working on a turbo engine:");
			engine = new TurboEngine(2000);
			diag = new EngineDiagnostics();
			inv = new EngineInventory();
			// Run diagnostics on the engine...
			engine.AcceptEngineVisitor(diag);
			// Run inventory on the engine...
			engine.AcceptEngineVisitor(inv);

			Console.ReadLine();
		}

	}
}
