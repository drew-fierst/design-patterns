using System;

namespace Prototype
{
	public class Client
	{
		static void Main()
		{
			Console.WriteLine();
			
			EngineManager manager = new EngineManager();

			IVehicle sedan1 = new Sedan(manager.GetEngine(EngineSize.Medium, false));
			IVehicle sedan2 = new Sedan(manager.GetEngine(EngineSize.Large, true));
			IVehicle pickup1 = new Pickup(manager.GetEngine(EngineSize.Large, false));
			IVehicle coupe1 = new Coupe(manager.GetEngine(EngineSize.Small, false));

			Console.WriteLine(sedan1);
			Console.WriteLine(sedan2);
			Console.WriteLine(pickup1);
			Console.WriteLine(coupe1);
			
			Console.ReadLine();
		}
	}
}
