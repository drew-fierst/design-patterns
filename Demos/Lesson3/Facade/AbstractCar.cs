﻿using System;

namespace Facade
{
	public abstract class AbstractCar : AbstractVehicle
	{

		public AbstractCar(IEngine engine)
				: this(engine, VehicleColor.Unpainted)
		{
		}

		public AbstractCar(IEngine engine, VehicleColor color)
				: base(engine, color)
		{
		}

	}
}
