using System;

namespace AbstractFactory
{
	public class Client
	{
		static void Main()
		{
			Console.WriteLine();
			BuildVehicle("car");
			
			Console.WriteLine();
			BuildVehicle("truck");

			Console.WriteLine("Done");
			Console.ReadLine();
		}

		static void BuildVehicle(string kind) {

			AbstractVehicleFactory factory = null;

			// Create the correct 'factory'...
			if (kind.Equals("car"))
			{
				factory = new CarFactory();
			}
			else
			{
				factory = new TruckFactory();
			}

			// Create the vehicle's component parts...
			// These will either be all car parts or all van parts
			IBody vehicleBody = factory.CreateBody();
			IChassis vehicleChassis = factory.CreateChassis();
			IWindows vehicleWindows = factory.CreateWindows();

			// Show what we've created...
			Console.WriteLine(vehicleBody.BodyParts);
			Console.WriteLine(vehicleChassis.ChassisParts);
			Console.WriteLine(vehicleWindows.WindowParts);
			Console.WriteLine();
		}

	}
}
