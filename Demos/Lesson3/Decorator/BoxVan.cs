using System;

namespace Decorator
{
	public class BoxVan : AbstractVan
	{

		public BoxVan(IEngine engine)
				: this(engine, VehicleColor.Unpainted)
		{
		}

		public BoxVan(IEngine engine, VehicleColor color)
				: base(engine, color)
		{
		}

		public override int Price
		{
			get
			{
				return 10000;
			}
		}

	}
}
