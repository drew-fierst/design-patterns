using System;

namespace Facade
{
	public class Coupe : AbstractCar
	{

		public Coupe(IEngine engine)
				: this(engine, VehicleColor.Unpainted)
		{
			Console.WriteLine("some stuff");
		}

		public Coupe(IEngine engine, VehicleColor color)
				: base(engine, color)
		{
		}

	}
}
