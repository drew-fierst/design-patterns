using System;

namespace Mediator
{
	public class Brake
	{
		private IEngineManager mediator;
		private bool enabled;
		private bool applied;

		// Constructor accepts mediator as an argument
		public Brake(IEngineManager mediator)
		{
			this.mediator = mediator;
			enabled = false;
			applied = false;
			mediator.RegisterBrake(this);
		}

		public virtual void Enable()
		{
			enabled = true;
			mediator.BrakeEnabled();
			Console.WriteLine("Brakes enabled");
		}

		public virtual void Disable()
		{
			enabled = false;
			mediator.BrakeDisabled();
			Console.WriteLine("Brakes disabled");
		}

		public virtual bool Enabled
		{
			get
			{
				return enabled;
			}
		}

		public virtual void Apply()
		{
			if (Enabled)
			{
				applied = true;
				mediator.BrakePressed();
				Console.WriteLine("Now braking");
			}
		}

		private void Release()
		{
			if (Enabled)
			{
				applied = false;
			}
		}

	}
}
