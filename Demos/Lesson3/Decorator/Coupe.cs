using System;

namespace Decorator
{
	public class Coupe : AbstractCar
	{

		public Coupe(IEngine engine)
				: this(engine, VehicleColor.Unpainted)
		{
		}

		public Coupe(IEngine engine, VehicleColor color)
				: base(engine, color)
		{
		}

		public override int Price
		{
			get
			{
				return 7000;
			}
		}

	}
}
