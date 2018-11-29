using System;

namespace Decorator
{
	public class Client
	{
		static void Main()
		{
			Console.WriteLine();

			// Create a blue sedan
			IVehicle myCar = new Sedan(new StandardEngine(1300));
			myCar.Paint(VehicleColor.Blue);
			Console.WriteLine(myCar);
			Console.WriteLine();

			// Add air-conditioning to the car...
			myCar = new AirConditionedVehicle(myCar);
			Console.WriteLine(myCar);
			Console.WriteLine();

			// Now add alloy wheels...
			myCar = new AlloyWheeledVehicle(myCar);
			Console.WriteLine(myCar);
			Console.WriteLine();

			// Now add leather seats...
			myCar = new LeatherSeatedVehicle(myCar);
			Console.WriteLine(myCar);
			Console.WriteLine();

			// Now add metallic paint...
			myCar = new MetallicPaintedVehicle(myCar);
			Console.WriteLine(myCar);
			Console.WriteLine();

			// Now add satellite navigation
			myCar = new SatNavVehicle(myCar);
			Console.WriteLine(myCar);
			Console.WriteLine();

			Console.ReadLine();
		}
	}
}
