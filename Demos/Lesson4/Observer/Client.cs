using System;

namespace Observer
{
	public class Client
	{
		static void Main()
		{
			Console.WriteLine();
			
			// Create a speedometer...
			Speedometer meter = new Speedometer();

			// Create a monitor...
			ParentalMonitor monitor = new ParentalMonitor(meter);

			// Add automatic transmission as an observer
			AutomaticTransmission auto = new AutomaticTransmission(meter);

			// Drive at different speeds...
			meter.CurrentSpeed = 50;
			meter.CurrentSpeed = 70;
			meter.CurrentSpeed = 35;
			meter.CurrentSpeed = 100;
			meter.CurrentSpeed = 69;

			Console.ReadLine();
		}

	}
}
