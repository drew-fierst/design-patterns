using System;

namespace FactoryMethod
{
	public abstract class AbstractVehicleFactory : IVehicleFactory
	{

		public static IVehicle Make(VehicleCategory cat, DrivingStyle style, VehicleColor color)
		{
			IVehicleFactory factory;

			if (cat == VehicleCategory.Car)
			{
				factory = new CarFactory();
			}
			else
			{
				factory = new VanFactory();
			}

			return factory.Build(style, color);
		}

		public virtual IVehicle Build(DrivingStyle style, VehicleColor color)
		{
			IVehicle v = SelectVehicle(style);
			v.Paint(color);
			return v;
		}

		// This is the "factory method"
		public abstract IVehicle SelectVehicle(DrivingStyle style);

	}
}
