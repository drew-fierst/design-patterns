using System;

namespace Builder
{
	public class VehicleDirector
	{
		public IVehicle Build(AbstractVehicleBuilder builder)
		{
			builder.BuildChassis();
			builder.BuildBody();
			builder.BuildPassengerArea();
			builder.BuildTrunk();
			builder.BuildReinforcedStorageArea();
			builder.BuildWindows();

			return builder.Vehicle;
		}
	}
}
