using System;

namespace State
{
	public class MonthSetupState : AbstractClockSetupState
	{
		public MonthSetupState(ClockSetup clockSetup)
			:base(clockSetup)
		{
			value = DateTime.Now.Month;
			minValue = 1;
			maxValue = 12;
		}

		public override void SelectValue()
		{
			Console.WriteLine("Month set to " + value);
			clockSetup.State = this.NextState;
		}

		public override string Instructions
		{
			get
			{
				return "Please set the month...";
			}
		}

	}
}
