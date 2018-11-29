using System;

namespace Interpreter
{
	public class Pickup : AbstractVan
	{

		public Pickup()
				: this(VehicleColor.Unpainted)
		{
		}

		public Pickup(VehicleColor color)
				: base(color)
		{
		}

	}
}
