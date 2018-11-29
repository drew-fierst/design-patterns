using System;

namespace FactoryMethod
{
	public class CarFactory : AbstractVehicleFactory
	{
		public override IVehicle SelectVehicle(DrivingStyle style)
		{
			IVehicle selectedVehicle;

			if (style == DrivingStyle.Economical)
			{
				selectedVehicle = new Sedan(new StandardEngine(1300));

			}
			else if (style == DrivingStyle.Midrange)
			{
				selectedVehicle = new Coupe(new StandardEngine(1600));

			}
			else
			{
				selectedVehicle = new Sport(new TurboEngine(2000));
			}

			return selectedVehicle;
		}

	}
}
