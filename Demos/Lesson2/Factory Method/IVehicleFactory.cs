using System;

namespace FactoryMethod
{
	public interface IVehicleFactory
	{
		IVehicle Build(DrivingStyle style, VehicleColor color);
		IVehicle SelectVehicle(DrivingStyle style);

	}
}