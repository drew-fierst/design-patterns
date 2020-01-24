using System;

namespace Facade
{
	public class Client
	{
		static void Main()
		{
			Console.WriteLine();
			Console.WriteLine("Preparing Vehicle for sale:");
			Console.WriteLine("Blah blah blah");
			
			VehicleFacade facade = new VehicleFacade();
			facade.PrepareForSale(new Sedan(new StandardEngine(1300)));

			Console.ReadLine();
		}
	}
}
