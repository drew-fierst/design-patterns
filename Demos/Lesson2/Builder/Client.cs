using System;

namespace Builder
{
	public class Client
	{
		static void Main()
		{
			Console.WriteLine();
			
			VehicleDirector director = new VehicleDirector();

			IVehicle vehicle = new Sedan(new StandardEngine(1300));
			AbstractVehicleBuilder builder = new CarBuilder(vehicle);
			IVehicle v = director.Build(builder);
			Console.WriteLine(v);

			Console.WriteLine("---------------------");

			vehicle = new Pickup(new StandardEngine(1800));
			builder = new VanBuilder(vehicle);
			v = director.Build(builder);
			Console.WriteLine(v);

			Console.ReadLine();
		}

	}
}
