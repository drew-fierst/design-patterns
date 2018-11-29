using System;

namespace Strategy
{
	public abstract class AbstractVehicle : IVehicle
	{
		private IEngine engine;
		private VehicleColor color;
		private IGearboxStrategy gearboxStrategy;

		public AbstractVehicle(IEngine engine)
				: this(engine, VehicleColor.Unpainted)
		{
		}

		public AbstractVehicle(IEngine engine, VehicleColor color)
		{
			this.engine = engine;
			this.color = color;
			// defaults to standard gearbox mode
			gearboxStrategy = new StandardGearboxStrategy();
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

		// Allow the gearbox strategy to be changed...
		public virtual IGearboxStrategy GearboxStrategy
		{
			set
			{
				this.gearboxStrategy = value;
			}
			get
			{
				return gearboxStrategy;
			}
		}

		public virtual int Speed
		{
			set
			{
				// Delegate to strategy in effect...
				gearboxStrategy.EnsureCorrectGear(Engine, value);
			}
		}

		public virtual void Paint(VehicleColor color)
		{
			this.color = color;
		}

		public override string ToString()
		{
			return this.GetType().Name + " (" + engine + ", " + color + ")";
		}

	}

}
