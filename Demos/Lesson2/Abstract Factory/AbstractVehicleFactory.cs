using System;

namespace AbstractFactory
{
	public abstract class AbstractVehicleFactory
	{
		public abstract IBody CreateBody();
		public abstract IChassis CreateChassis();
		public abstract IWindows CreateWindows();
	}
}
