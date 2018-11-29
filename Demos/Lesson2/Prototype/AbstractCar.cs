using System;

namespace Prototype
{
	public abstract class AbstractCar : AbstractVehicle
	{

		public AbstractCar(IEngine engine)
				: this(engine, VehicleColor.UNPAINTED)
		{
		}

		public AbstractCar(IEngine engine, VehicleColor color)
				: base(engine, color)
		{
		}

	}
}
