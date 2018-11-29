using System;

namespace Interpreter 
{
	public class VehicleExpression : IBuilderExpression
	{
		private string vehicleType;

		public VehicleExpression(string vehicleType)
		{
			this.vehicleType = vehicleType;
		}

		public IBuilderExpression NextExpression { get; set; }

		public IVehicle Interpret(IVehicle vehicle)
		{
			//ignore the "vehicle" parameter - this expression is supposed to start a new vehicle
			IVehicle newVehicle = null;
			switch (vehicleType)
			{
				case "coupe":
					newVehicle = new Coupe();
					break;
				case "sedan":
					newVehicle = new Sedan();
					break;
				case "sport":
					newVehicle = new Sport();
					break;
				case "pickup":
					newVehicle = new Pickup();
					break;
				case "boxvan":
					newVehicle = new BoxVan();
					break;
			}

			if (NextExpression != null)
			{
				newVehicle = NextExpression.Interpret(newVehicle);
			}

			return newVehicle;
		}
	}
}