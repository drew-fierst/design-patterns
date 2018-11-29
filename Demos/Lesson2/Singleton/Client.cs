using System;

namespace Singleton
{
	public class Client
	{
		static void Main()
		{
			Console.WriteLine();
			
			SerialNumberGenerator generator = SerialNumberGenerator.Instance;

			//SerialNumberGenerator gen = new SerialNumberGenerator();	//compile error!

			Console.WriteLine("next serial: " + generator.NextSerial);
			Console.WriteLine("next serial: " + generator.NextSerial);
			Console.WriteLine("next serial: " + SerialNumberGenerator.Instance.NextSerial);
			Console.WriteLine("next serial: " + generator.NextSerial);

			Console.ReadLine();
		}
	}
}
