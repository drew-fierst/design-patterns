using System;

namespace Flyweight
{
	public class Client
	{
		static void Main()
		{
			Console.WriteLine();
			
			// Create the flyweight factory...
			EngineFlyweightFactory factory = EngineFlyweightFactory.GetInstance();

			// Get the flyweights 
			IEngine standard1 = factory.GetStandardEngine(1300);
			IEngine standard2 = factory.GetStandardEngine(1300);
			IEngine standard3 = factory.GetTurboEngine(1300);
			IEngine standard4 = factory.GetStandardEngine(1600);
			IEngine standard5 = factory.GetStandardEngine(1600);


			// Show that objects are shared
			Console.WriteLine(standard1.GetHashCode());
			Console.WriteLine(standard2.GetHashCode());
			Console.WriteLine(standard3.GetHashCode());
			Console.WriteLine(standard4.GetHashCode());
			Console.WriteLine(standard5.GetHashCode());

			Console.ReadLine();
		}
	}
}
