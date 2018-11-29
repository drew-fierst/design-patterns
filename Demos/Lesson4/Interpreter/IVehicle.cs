using System;

namespace Interpreter
{
	public interface IVehicle
	{
		IEngine Engine { get; }
		VehicleColor Color { get; }
		void Paint(VehicleColor color);

		void InstallEngine(IEngine engine);
	}
}
