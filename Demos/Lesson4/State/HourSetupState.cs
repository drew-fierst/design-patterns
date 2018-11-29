using System;

namespace State
{
	public class HourSetupState : AbstractClockSetupState
	{
		public HourSetupState(ClockSetup clockSetup)
			:base(clockSetup)
		{
			value = DateTime.Now.Hour;
			minValue = 0;
			maxValue = 23;
		}

		public override void SelectValue()
		{
			Console.WriteLine("Hour set to " + value);
			clockSetup.State = this.nextState;
		}

		public override string Instructions
		{
			get
			{
				return "Please set the hour...";
			}
		}

	}
}
