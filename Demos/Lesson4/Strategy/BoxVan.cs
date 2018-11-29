﻿using System;

namespace Strategy
{
	public class BoxVan : AbstractVan
	{
		public BoxVan(IEngine engine)
				: this(engine, VehicleColor.Unpainted)
		{
		}

		public BoxVan(IEngine engine, VehicleColor color)
				: base(engine, color)
		{
		}

	}
}