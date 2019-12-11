using System;

namespace AbstractFactory
{
	public class TruckChassis : IChassis
	{

		public virtual string ChassisParts
		{
			get
			{
				return "Chassis parts for a truck";
			}
		}

	}
}
