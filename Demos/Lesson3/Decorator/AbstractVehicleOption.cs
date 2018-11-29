using System;

namespace Decorator
{
	public abstract class AbstractVehicleOption : AbstractVehicle
	{
		protected internal IVehicle decoratedVehicle;

		public AbstractVehicleOption(IVehicle vehicle)
				: base(vehicle.Engine, vehicle.Color)
		{
			decoratedVehicle = vehicle;
		}

		public virtual string FriendlyName
		{
			get
			{
				return string.Empty;
			}
		}

		public override string GetDescription()
		{
			return this.FriendlyName + ", " + decoratedVehicle.GetDescription();
		}

	}
}
