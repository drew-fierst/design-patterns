using System;

namespace Bridge
{
	public class Client
	{
		static void Main()
		{
			Console.WriteLine();

			IEngine engine = new StandardEngine(1300);
			AbstractDriverControls controls = new StandardControls(engine);
			controls.IgnitionOn();
			controls.Accelerate();
			controls.Brake();

			Console.WriteLine();
			Console.WriteLine();
			
			//same interface reference variable can use different engine and different controls
			IEngine turbo = new TurboEngine(1300);
			controls = new SportControls(turbo);
			controls.IgnitionOn();
			controls.Accelerate();
			controls.Brake();

			Console.ReadLine();
		}
	}
}
