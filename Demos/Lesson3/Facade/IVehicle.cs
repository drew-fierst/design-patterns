using System;

namespace Facade
{
	public interface IVehicle
	{
		IEngine Engine { get; }
		VehicleColor Color { get; }
		void Paint(VehicleColor color);

		void CleanInterior();
		void CleanExteriorBody();
		void PolishWindows();
		void TakeForTestDrive();
	}
}
