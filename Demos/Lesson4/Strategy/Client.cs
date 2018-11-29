using System;

namespace Strategy
{
	public class Client
	{
		static void Main()
		{
			Console.WriteLine();

			Console.WriteLine("sedan with a standard gearbox...");
			IVehicle myCar = new Sedan(new StandardEngine(1500));
			myCar.Speed = 20;
			myCar.Speed = 40;

			Console.WriteLine();
			Console.WriteLine("sports car with a sport gearbox...");
			myCar = new Sport(new TurboEngine(2000));
			myCar.GearboxStrategy = new SportGearboxStrategy();
			myCar.Speed = 20;
			myCar.Speed = 40;

			Console.WriteLine();
			Console.WriteLine("pickup with a high-torque gearbox...");
			myCar = new Pickup(new StandardEngine(1800));
			myCar.GearboxStrategy = new HighTorqueGearboxStrategy();
			myCar.Speed = 20;
			myCar.Speed = 40;

			Console.ReadLine();
		}

	}
}
