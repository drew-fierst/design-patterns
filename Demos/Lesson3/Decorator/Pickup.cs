using System;

namespace Decorator
{
	public class Pickup : AbstractVan
	{

		public Pickup(IEngine engine)
				: this(engine, VehicleColor.Unpainted)
		{
		}

		public Pickup(IEngine engine, VehicleColor color)
				: base(engine, color)
		{
		}

		public override int Price
		{
			get
			{
				return 9000;
			}
		}

	}
}
