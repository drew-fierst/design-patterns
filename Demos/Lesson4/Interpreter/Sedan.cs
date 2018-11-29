using System;

namespace Interpreter
{
	public class Sedan : AbstractCar
	{

		public Sedan()
				: this(VehicleColor.Unpainted)
		{
		}

		public Sedan(VehicleColor color)
				: base(color)
		{
		}

	}
}
