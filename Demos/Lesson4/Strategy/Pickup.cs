﻿using System;

namespace Strategy
{
	public class Pickup : AbstractVan
	{

		public Pickup(IEngine engine)
				: this(engine, VehicleColor.Unpainted)
		{
		}

		public Pickup(IEngine engine, VehicleColor color)
				: base(engine, color)
		{
		}

	}
}
