using System;

namespace Decorator
{
	public class AlloyWheeledVehicle : AbstractVehicleOption
	{
		public AlloyWheeledVehicle(IVehicle vehicle)
				: base(vehicle)
		{
		}

		public override int Price
		{
			get
			{
				return decoratedVehicle.Price + 250;
			}
		}

		public override string FriendlyName
		{
			get
			{
				return "Alloy Wheeled";
			}
		}

		public override bool HasOption(AbstractVehicleOption opt)
		{

			if (opt is AlloyWheeledVehicle)
			{
				return true;
			}
			else
			{
				return decoratedVehicle.HasOption(opt);
			}

		}

	}
}
