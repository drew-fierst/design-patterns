using System;

namespace Prototype
{
	public class Sedan : AbstractCar
	{

		public Sedan(IEngine engine)
				: this(engine, VehicleColor.UNPAINTED)
		{
		}

		public Sedan(IEngine engine, VehicleColor color)
				: base(engine, color)
		{
		}

	}
}
