using System;

namespace Iterator
{
	public class Client
	{
		static void Main()
		{
			Console.WriteLine();
			
			IContainer<PaintInstructions> shop = new PaintShop();

			shop.AddItem(new PaintInstructions(new Sedan(new StandardEngine(1500)), VehicleColor.Blue));
			shop.AddItem(new PaintInstructions(new Coupe(new StandardEngine(1800)), VehicleColor.Black));
			shop.AddItem(new PaintInstructions(new Pickup(new StandardEngine(1800)), VehicleColor.Silver));
			shop.AddItem(new PaintInstructions(new Sport(new TurboEngine(2000)), VehicleColor.Red));

			IIterator<PaintInstructions> schedule = shop.GetIterator();

			while (schedule.HasNext())
			{
				PaintInstructions task = schedule.GetNext();
				Console.WriteLine("Painting a " + task.Vehicle.ToString() + " " + task.Color.ToString());
			}

			Console.ReadLine();
		}

	}
}
