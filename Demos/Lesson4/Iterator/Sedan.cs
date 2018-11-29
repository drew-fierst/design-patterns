using System;

namespace Iterator
{
	public class Sedan : AbstractCar
	{

		public Sedan(IEngine engine)
				: this(engine, VehicleColor.Unpainted)
		{
		}

		public Sedan(IEngine engine, VehicleColor color)
				: base(engine, color)
		{
		}

	}
}
