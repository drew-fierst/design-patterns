using System;
using System.Collections.Generic;

namespace Adapter
{
	public class Client
	{
		static void Main()
		{
			Console.WriteLine();
			
			IList<IEngine> engines = new List<IEngine>();

			engines.Add(new StandardEngine(1300));
			engines.Add(new StandardEngine(1600));
			engines.Add(new TurboEngine(2000));

			// "Adapt" the new engine type
			ElectricEngine greenEngine = new ElectricEngine(1200);
			engines.Add(new ElectricEngineAdapter(greenEngine));

			foreach (IEngine engine in engines)
			{
				Console.WriteLine(engine);
			}
			
			Console.ReadLine();
		}
	}
}
