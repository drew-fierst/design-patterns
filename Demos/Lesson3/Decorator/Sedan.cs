using System;

namespace Decorator
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

		public override int Price
		{
			get
			{
				return 6000;
			}
		}
	}
}
