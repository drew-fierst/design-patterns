using System;

namespace AbstractFactory
{
	public class CarFactory : AbstractVehicleFactory
	{

		public override IBody CreateBody()
		{
			return new CarBody();
		}

		public override IChassis CreateChassis()
		{
			return new CarChassis();
		}

		public override IWindows CreateWindows()
		{
			return new CarWindows();
		}

	}
}
