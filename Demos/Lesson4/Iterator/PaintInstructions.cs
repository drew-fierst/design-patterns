using System;

namespace Iterator
{
	public class PaintInstructions
	{
		private VehicleColor color;
		private IVehicle vehicle;

		public PaintInstructions(IVehicle vehicle, VehicleColor color) 
		{
			this.vehicle = vehicle;
			this.color = color;
		}

		public virtual VehicleColor Color
		{
			get
			{
				return color;
			}
		}

		public virtual IVehicle Vehicle 
		{
			get 
			{
				return vehicle;
			}
			set
			{
				vehicle = value;
			}
		}
	}
}