using System;
using System.Collections.Generic;

namespace Visitor
{
	public class EngineDiagnostics : IEngineVisitor
	{
		public IList<string> PistonResults;
		public IList<string> SparkPlugResults;
		public IList<string> CamshaftResults;
		public string EngineResults;

		public EngineDiagnostics()
		{
			PistonResults = new List<string>();
			SparkPlugResults = new List<string>();
			CamshaftResults = new List<string>();
		}

		public virtual void Visit(Camshaft camshaft)
		{
			CamshaftResults.Add("  Diagnosing a camshaft");
		}

		public virtual void Visit(IEngine engine)
		{
			Console.WriteLine("Diagnosing the engine:");
			foreach (string value in CamshaftResults) {
				Console.WriteLine(value);
			}
			foreach (string value in PistonResults)
			{
				Console.WriteLine(value);
			}
			foreach (string value in SparkPlugResults)
			{
				Console.WriteLine(value);
			}
		}

		public virtual void Visit(Piston piston)
		{
			PistonResults.Add("  Diagnosing a single piston");
		}

		public virtual void Visit(SparkPlug sparkPlug)
		{
			SparkPlugResults.Add("  Diagnosing a single spark plug");
		}

	}
}
