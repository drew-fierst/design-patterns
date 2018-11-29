using System;

namespace Prototype
{
	public abstract class AbstractVan : AbstractVehicle
	{

		public AbstractVan(IEngine engine)
				: this(engine, VehicleColor.UNPAINTED)
		{
		}

		public AbstractVan(IEngine engine, VehicleColor color)
				: base(engine, color)
		{
		}

	}
}
