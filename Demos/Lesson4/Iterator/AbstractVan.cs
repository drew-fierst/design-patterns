using System;

namespace Iterator
{
	public abstract class AbstractVan : AbstractVehicle
	{

		public AbstractVan(IEngine engine)
				: this(engine, VehicleColor.Unpainted)
		{
		}

		public AbstractVan(IEngine engine, VehicleColor color)
				: base(engine, color)
		{
		}

	}
}
