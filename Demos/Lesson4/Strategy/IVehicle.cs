using System;

namespace Strategy
{
	public interface IVehicle
	{
		IEngine Engine { get; }
		VehicleColor Color { get; }
		IGearboxStrategy GearboxStrategy { get; set; }
		int Speed { set; }
		void Paint(VehicleColor color);
	}
}
