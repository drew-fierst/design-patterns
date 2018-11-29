using System;

namespace Interpreter
{
	public class Client
	{
		static void Main()
		{
			Console.WriteLine();
			
			IVehicle vehicle;
			BuilderInterpreter interpreter = new BuilderInterpreter();

			string descr = "blue turbo coupe";
			if (interpreter.TryParse(descr))
			{
				vehicle = interpreter.Interpret();
				Console.WriteLine(vehicle);
			}

			descr = "pickup red";
			if (interpreter.TryParse(descr))
			{
				vehicle = interpreter.Interpret();
				Console.WriteLine(vehicle);
			}

			descr = "turbo sport black";
			if (interpreter.TryParse(descr))
			{
				vehicle = interpreter.Interpret();
				Console.WriteLine(vehicle);
			}

			Console.ReadLine();
		}
	}
}
