using System;

namespace AbstractFactory
{
	public class CarChassis : IChassis
	{

		public virtual string ChassisParts
		{
			get
			{
				return "Chassis parts for a car";
			}
		}

	}
}
