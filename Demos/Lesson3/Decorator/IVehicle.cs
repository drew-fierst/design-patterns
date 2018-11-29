using System;

namespace Decorator
{
	public interface IVehicle
	{
		IEngine Engine { get; }
		VehicleColor Color { get; }
		void Paint(VehicleColor color);

		int Price { get; }
		bool HasOption(AbstractVehicleOption opt);
		string GetDescription();

	}
}
