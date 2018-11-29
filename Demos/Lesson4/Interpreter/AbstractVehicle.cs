using System;

namespace Interpreter
{
	public abstract class AbstractVehicle : IVehicle
	{
		private IEngine engine;
		private VehicleColor color;

		public AbstractVehicle()
				: this(VehicleColor.Unpainted)
		{
		}

		public AbstractVehicle(VehicleColor color)
		{
			this.engine = null;
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

		public virtual void InstallEngine(IEngine engine)
		{
			this.engine = engine;
		}

		public override string ToString()
		{
			return this.GetType().Name + " (" + engine + ", " + color + ")";
		}

	}

}
