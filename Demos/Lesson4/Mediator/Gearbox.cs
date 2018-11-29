using System;

namespace Mediator
{
	public class Gearbox
	{
		private IEngineManager mediator;
		private bool enabled;
		private Gear currentGear;

		// Constructor accepts mediator as an argument
		public Gearbox(IEngineManager mediator)
		{
			this.mediator = mediator;
			enabled = false;
			currentGear = Gear.Neutral;
			mediator.RegisterGearbox(this);
		}

		public virtual void Enable()
		{
			enabled = true;
			mediator.GearboxEnabled();
			Console.WriteLine("Gearbox enabled");
		}

		public virtual void Disable()
		{
			enabled = false;
			mediator.GearboxDisabled();
			Console.WriteLine("Gearbox disabled");
		}

		public virtual bool Enabled
		{
			get
			{
				return enabled;
			}
		}

		public virtual Gear Gear
		{
			set
			{
				if ((Enabled) && (Gear != value))
				{
					currentGear = value;
					mediator.GearChanged();
					Console.WriteLine("Now in " + Gear + " gear");
				}
			}
			get
			{
				return currentGear;
			}
		}

	}
}
