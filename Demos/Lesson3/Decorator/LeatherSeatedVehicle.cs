using System;

namespace Decorator
{
	public class LeatherSeatedVehicle : AbstractVehicleOption
	{
		public LeatherSeatedVehicle(IVehicle vehicle)
				: base(vehicle)
		{
		}

		public override int Price
		{
			get
			{
				return decoratedVehicle.Price + 1200;
			}
		}

		public override string FriendlyName
		{
			get
			{
				return "Leather Seated";
			}
		}

		public override bool HasOption(AbstractVehicleOption opt)
		{

			if (opt is LeatherSeatedVehicle)
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
