using System;

namespace AbstractFactory
{
	public class TruckFactory : AbstractVehicleFactory
	{

		public override IBody CreateBody()
		{
			return new TruckBody();
		}

		public override IChassis CreateChassis()
		{
			return new TruckChassis();
		}

		public override IWindows CreateWindows()
		{
			return new TruckWindows();
		}

	}
}
