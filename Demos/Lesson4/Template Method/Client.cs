using System;

namespace Template
{
	public class Client
	{
		static void Main()
		{
			Console.WriteLine();

			Console.WriteLine("About to print a booklet for sedan cars");
			AbstractBookletPrinter sedanBooklet = new SedanBooklet();
			sedanBooklet.Print();

			Console.WriteLine();
			Console.WriteLine("---------------------------------");
			Console.WriteLine();
			Console.WriteLine("About to print a service history booklet");
			AbstractBookletPrinter serviceBooklet = new ServiceHistoryBooklet();
			serviceBooklet.Print();

			Console.ReadLine();
		}

	}
}
