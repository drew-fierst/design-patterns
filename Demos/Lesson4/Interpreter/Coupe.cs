using System;

namespace Interpreter
{
	public class Coupe : AbstractCar
	{

		public Coupe()
				: this(VehicleColor.Unpainted)
		{
		}

		public Coupe(VehicleColor color)
				: base(color)
		{
		}

	}
}
