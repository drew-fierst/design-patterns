using System;

namespace Interpreter
{
	public abstract class AbstractCar : AbstractVehicle
	{

		public AbstractCar()
				: this(VehicleColor.Unpainted)
		{
		}

		public AbstractCar(VehicleColor color)
				: base(color)
		{
		}

	}
}
