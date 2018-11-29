using System;

namespace State
{
	public class MinuteSetupState : AbstractClockSetupState
	{
		public MinuteSetupState(ClockSetup clockSetup)
			:base(clockSetup)
		{
			value = DateTime.Now.Minute;
			minValue = 0;
			maxValue = 59;
		}

		public override void SelectValue()
		{
			Console.WriteLine("Minute set to " + value);
			clockSetup.State = this.nextState;
		}

		public override string Instructions
		{
			get
			{
				return "Please set the minute...";
			}
		}

	}
}
