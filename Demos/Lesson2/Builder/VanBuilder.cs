using System;

namespace Builder
{
	public class VanBuilder : AbstractVehicleBuilder
	{

		private IVehicle vanInProgress;

		public VanBuilder(IVehicle van)
		{
			vanInProgress = van;
		}


		public override void BuildBody()
		{
			Console.WriteLine("building van body");
		}

		public override void BuildPassengerArea()
		{
			//do nothing - vans don't have a passenger area
		}

		public override void BuildTrunk()
		{
			//do nothing - vans don't have a trunk
		}

		public override void BuildChassis()
		{
			Console.WriteLine("building van chassis");
		}

		public override void BuildReinforcedStorageArea()
		{
			Console.WriteLine("building van storage area");
		}

		public override void BuildWindows()
		{
			Console.WriteLine("building van windows");
		}

		public override IVehicle Vehicle
		{
			get
			{
				return vanInProgress;
			}
		}


	}
}
