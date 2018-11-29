using System;

namespace Decorator
{
	public class SatNavVehicle : AbstractVehicleOption
	{
		public SatNavVehicle(IVehicle vehicle)
				: base(vehicle)
		{
		}

		public override int Price
		{
			get
			{
				return decoratedVehicle.Price + 1500;
			}
		}

		public override string FriendlyName
		{
			get
			{
				return "Sattelite Navigation";
			}
		}

		public override bool HasOption(AbstractVehicleOption opt)
		{

			if (opt is SatNavVehicle)
			{
				return true;
			}
			else
			{
				return decoratedVehicle.HasOption(opt);
			}

		}

		public virtual string Destination
		{
			set
			{
				// code to set the destination...
			}
		}

	}
}
