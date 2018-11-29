using System;

namespace Decorator
{
	public abstract class AbstractVehicle : IVehicle
	{
		private IEngine engine;
		private VehicleColor color;

		public AbstractVehicle(IEngine engine)
				: this(engine, VehicleColor.Unpainted)
		{
		}

		public AbstractVehicle(IEngine engine, VehicleColor color)
		{
			this.engine = engine;
			this.color = color;
		}

		public virtual IEngine Engine
		{
			get
			{
				return engine;
			}
		}

		public virtual VehicleColor Color
		{
			get
			{
				return color;
			}
		}

		public virtual void Paint(VehicleColor color)
		{
			this.color = color;
		}

		public virtual bool HasOption(AbstractVehicleOption opt)
		{
			return false;
		}

		public abstract int Price { get; }

		public virtual string GetDescription()
		{
			return this.GetType().Name + " (" + engine + ", " + color + ")";
		}

		public override string ToString()
		{
			return this.GetDescription() + ", price " + this.Price;
		}

	}

}
