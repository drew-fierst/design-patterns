using System;

namespace Decorator
{
	public class MetallicPaintedVehicle : AbstractVehicleOption
	{
		public MetallicPaintedVehicle(IVehicle vehicle)
				: base(vehicle)
		{
		}

		public override int Price
		{
			get
			{
				return decoratedVehicle.Price + 750;
			}
		}

		public override string FriendlyName
		{
			get
			{
				return "Metallic Painted";
			}
		}

		public override bool HasOption(AbstractVehicleOption opt)
		{

			if (opt is MetallicPaintedVehicle)
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
