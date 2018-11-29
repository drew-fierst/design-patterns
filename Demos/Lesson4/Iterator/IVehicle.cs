using System;

namespace Iterator
{
	public interface IVehicle
	{
		IEngine Engine { get; }
		VehicleColor Color { get; }
		void Paint(VehicleColor color);
	}
}
