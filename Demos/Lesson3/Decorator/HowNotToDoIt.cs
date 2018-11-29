using System;

namespace Demo
{
	public class Car
	{

		//code for options
		private bool leatherSeats;
		public bool LeatherSeats
		{
			get { return leatherSeats; }
			set { leatherSeats = value; }
		}

		private bool alloyWheels;
		public bool AlloyWheels
		{
			get { return alloyWheels; }
			set { alloyWheels = value; }
		}

		//price of the vehicle
		public decimal Price
		{
			get
			{
				decimal workingPrice = 12000;

				if (LeatherSeats)
				{
					workingPrice += 800;
				}

				if (AlloyWheels)
				{
					workingPrice += 750;
				}

				return workingPrice;
			}
		}

	}
}