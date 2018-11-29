using System;

namespace Mediator
{
	public class Client
	{
		static void Main()
		{
			Console.WriteLine();
			
			IEngineManager ems = new EngineManagementSystem();

			Ignition ignition = new Ignition(ems);
			Gearbox gearbox = new Gearbox(ems);
			Accelerator accelerator = new Accelerator(ems);
			Brake brake = new Brake(ems);

			ignition.Start();
			accelerator.AccelerateToSpeed(35);
			brake.Apply();

			Console.ReadLine();
		}

	}
}
