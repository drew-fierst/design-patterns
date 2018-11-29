using System;

namespace FactoryMethod
{
	public class Client
	{
		static void Main()
		{
			Console.WriteLine();

			// USING INSTANCE FACTORY (client is deciding which concrete factory to use)
			// I want an economical car, colored blue...
			IVehicleFactory carFactory = new CarFactory();
			IVehicle car = carFactory.Build(DrivingStyle.Economical, VehicleColor.Blue);
			Console.WriteLine(car);

			// I want a white van ...
			IVehicleFactory vanFactory = new VanFactory();
			IVehicle van = vanFactory.Build(DrivingStyle.Powerful, VehicleColor.White);
			Console.WriteLine(van);


			// USING STATIC FACTORY (abstract factory is deciding which concrete factory to use)
			// Create a red sports car...
			IVehicle sporty = AbstractVehicleFactory.Make(VehicleCategory.Car, DrivingStyle.Powerful, VehicleColor.Red);
			Console.WriteLine(sporty);

			Console.ReadLine();
		}
	}
}
