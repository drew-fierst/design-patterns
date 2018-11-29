using System;

namespace State
{
	public class DaySetupState : AbstractClockSetupState
	{
		public DaySetupState(ClockSetup clockSetup)
			:base(clockSetup)
		{
			value = DateTime.Now.Day;
			minValue = 0;
		}

		public override void PreviousValue()
		{
			maxValue = DateTime.DaysInMonth(clockSetup.YearSetupState.SelectedValue, clockSetup.MonthSetupState.SelectedValue);
			base.PreviousValue();
		}

		public override void NextValue()
		{
			maxValue = DateTime.DaysInMonth(clockSetup.YearSetupState.SelectedValue, clockSetup.MonthSetupState.SelectedValue);
			base.NextValue();
		}

		public override void SelectValue()
		{
			Console.WriteLine("Day set to " + value);
			clockSetup.State = this.NextState;
		}

		public override string Instructions
		{
			get
			{
				return "Please set the day...";
			}
		}

	}
}
