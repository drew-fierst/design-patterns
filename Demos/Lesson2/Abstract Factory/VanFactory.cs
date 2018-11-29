using System;

namespace AbstractFactory
{
	public class VanFactory : AbstractVehicleFactory
	{

		public override IBody CreateBody()
		{
			return new VanBody();
		}

		public override IChassis CreateChassis()
		{
			return new VanChassis();
		}

		public override IWindows CreateWindows()
		{
			return new VanWindows();
		}

	}
}
