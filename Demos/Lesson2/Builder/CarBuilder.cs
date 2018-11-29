using System;

namespace Builder
{
	public class CarBuilder : AbstractVehicleBuilder
	{

		private IVehicle carInProgress;

		public CarBuilder(IVehicle car)
		{
			carInProgress = car;
		}

		public override void BuildBody()
		{
			Console.WriteLine("building car body");
		}

		public override void BuildTrunk()
		{
			Console.WriteLine("building car trunk");
		}

		public override void BuildChassis()
		{
			Console.WriteLine("building car chassis");
		}

		public override void BuildPassengerArea()
		{
			Console.WriteLine("building car passenger area");
		}

		public override void BuildWindows()
		{
			Console.WriteLine("building car windows");
		}

		public override void BuildReinforcedStorageArea()
		{
			//do nothing, cars don't have a reinforced storage area
		}

		public override IVehicle Vehicle
		{
			get
			{
				return carInProgress;
			}
		}

	}
}
