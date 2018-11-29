using System;

namespace Interpreter
{
	public class BoxVan : AbstractVan
	{

		public BoxVan()
				: this(VehicleColor.Unpainted)
		{
		}

		public BoxVan(VehicleColor color)
				: base(color)
		{
		}

	}
}
