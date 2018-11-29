using System;

namespace Builder
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

		public override string ToString()
		{
			return this.GetType().Name + " (" + engine + ", " + color + ")";
		}

	}

}
