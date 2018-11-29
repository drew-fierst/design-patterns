using System;

namespace Interpreter
{
	public class Sport : AbstractCar
	{

		public Sport()
				: this(VehicleColor.Unpainted)
		{
		}

		public Sport(VehicleColor color)
				: base(color)
		{
		}

	}
}
