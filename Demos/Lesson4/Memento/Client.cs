using System;

namespace Memento
{
	public class Client
	{
		static void Main()
		{
			Console.WriteLine();

			Speedometer meter = new Speedometer();
			CruiseControl cruise = new CruiseControl(meter);

			meter.CurrentSpeed = 50;
			Console.WriteLine("Current speed: " + meter.CurrentSpeed);
			meter.CurrentSpeed = 70;
			Console.WriteLine("Current speed: " + meter.CurrentSpeed);

			// save the state
			cruise.Set();

			// Change the state
			meter.CurrentSpeed = 80;
			Console.WriteLine("After setting to 80...");
			Console.WriteLine("Current speed: " + meter.CurrentSpeed);

			// Restore the state
			Console.WriteLine("Now restoring state...");
			cruise.Resume();
			Console.WriteLine("Current speed: " + meter.CurrentSpeed);

			Console.ReadLine();
		}

	}
}
