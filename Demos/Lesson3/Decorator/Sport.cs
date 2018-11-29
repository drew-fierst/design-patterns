using System;

namespace Decorator
{
	public class Sport : AbstractCar
	{

		public Sport(IEngine engine)
				: this(engine, VehicleColor.Unpainted)
		{
		}

		public Sport(IEngine engine, VehicleColor color)
				: base(engine, color)
		{
		}

		public override int Price
		{
			get
			{
				return 8000;
			}
		}

	}
}
