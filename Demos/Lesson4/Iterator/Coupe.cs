﻿using System;

namespace Iterator
{
	public class Coupe : AbstractCar
	{

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
