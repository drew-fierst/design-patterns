using System;

namespace FactoryMethod
{
	public class VanFactory : AbstractVehicleFactory
	{
		public override IVehicle SelectVehicle(DrivingStyle style)
		{
			IVehicle selectedVehicle;

			if ((style == DrivingStyle.Economical) || (style == DrivingStyle.Midrange))
			{
				selectedVehicle = new Pickup(new StandardEngine(2200));
			}
			else
			{
				selectedVehicle = new BoxVan(new TurboEngine(2500));
			}

			return selectedVehicle;
		}

	}
}
