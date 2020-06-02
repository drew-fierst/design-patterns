using System;

namespace Facade
{
	public class Coupe : AbstractCar
	{
		// comment by Drew
		
		public Coupe(IEngine engine)
				: this(engine, VehicleColor.Unpainted)
		{
		}

		public Coupe(IEngine engine, VehicleColor color)
				: base(engine, color)
		{
		}

	}
}
