using System;

namespace Prototype
{
	public abstract class AbstractVehicle : IVehicle
	{
		private IEngine engine;
		private VehicleColor color;

		public AbstractVehicle(IEngine engine) : this(engine, VehicleColor.UNPAINTED)
		{
		}

		public AbstractVehicle(IEngine engine, VehicleColor color)
		{
			this.engine = engine;
			this.color = color;
			// ... followed by lots of time-consuming stuff
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

		public override string ToString()
		{
			return this.GetType().Name + " (" + engine + ", " + color + ")";
		}

	}

}
