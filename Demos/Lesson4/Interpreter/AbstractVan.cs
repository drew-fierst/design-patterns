using System;

namespace Interpreter
{
	public abstract class AbstractVan : AbstractVehicle
	{

		public AbstractVan()
				: this(VehicleColor.Unpainted)
		{
		}

		public AbstractVan(VehicleColor color)
				: base(color)
		{
		}

	}
}
