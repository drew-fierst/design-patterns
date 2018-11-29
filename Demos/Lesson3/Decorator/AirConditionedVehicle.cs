using System;

namespace Decorator
{
	public class AirConditionedVehicle : AbstractVehicleOption
	{
		public AirConditionedVehicle(IVehicle vehicle)
				: base(vehicle)
		{
		}

		public override int Price
		{
			get
			{
				return decoratedVehicle.Price + 600;
			}
		}

		public override bool HasOption(AbstractVehicleOption opt)
		{

			if (opt is AirConditionedVehicle)
			{
				return true;
			}
			else
			{
				return decoratedVehicle.HasOption(opt);
			}

		}

		public override string FriendlyName
		{
			get
			{
				return "Air Conditioned";
			}
		}

		public virtual int Temperature
		{
			set
			{
				// code to set the temperature...
			}
		}
	}
}
