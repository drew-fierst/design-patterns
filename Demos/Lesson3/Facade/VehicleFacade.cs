using System;

namespace Facade
{
	public class VehicleFacade
	{
		public virtual void PrepareForSale(IVehicle vehicle)
		{
			Registration reg = new Registration(vehicle);
			reg.AllocateVehicleNumber();
			reg.AllocateLicensePlate();

			Documentation.PrintBrochure(vehicle);

			vehicle.TakeForTestDrive();
			vehicle.CleanInterior();
			vehicle.CleanExteriorBody();
			vehicle.PolishWindows();

		}
	}
}
