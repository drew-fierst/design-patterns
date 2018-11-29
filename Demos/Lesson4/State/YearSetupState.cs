using System;

namespace State
{
	public class YearSetupState : AbstractClockSetupState
	{

		public YearSetupState(ClockSetup clockSetup)
			:base(clockSetup)
		{
			value = DateTime.Now.Year;
			minValue = 1950;
			maxValue = 2050;
		}

		public override void SelectValue()
		{
			Console.WriteLine("Year set to " + value);
			clockSetup.State = this.NextState;
		}

		public override string Instructions
		{
			get
			{
				return "Please set the year...";
			}
		}


	}
}
