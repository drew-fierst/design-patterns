using System;

namespace Interpreter
{
	public class PaintColorExpression : IBuilderExpression
	{
		private string color;

		public PaintColorExpression(string color)
		{
			this.color = color;
		}

		public IBuilderExpression NextExpression { get; set; }

		public IVehicle Interpret(IVehicle vehicle)
		{
			VehicleColor newColor = VehicleColor.Unpainted;

			switch (color) {
				case "red":
					newColor = VehicleColor.Red;
					break;
				case "black":
					newColor = VehicleColor.Black;
					break;
				case "white":
					newColor = VehicleColor.White;
					break;
				case "blue":
					newColor = VehicleColor.Blue;
					break;
				case "green":
					newColor = VehicleColor.Green;
					break;
				case "silver":
					newColor = VehicleColor.Silver;
					break;
				case "yellow":
					newColor = VehicleColor.Yellow;
					break;
			}
			vehicle.Paint(newColor);

			if (NextExpression != null)
			{
				vehicle = NextExpression.Interpret(vehicle);
			}

			return vehicle;
		}

	}
}