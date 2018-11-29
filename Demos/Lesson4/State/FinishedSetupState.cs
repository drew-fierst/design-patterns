using System;

namespace State
{
	public class FinishedSetupState : AbstractClockSetupState
	{
		public FinishedSetupState(ClockSetup clockSetup)
			:base(clockSetup)
		{
		}

		public override void PreviousValue()
		{
			Console.WriteLine("Ignored...");
		}

		public override void NextValue()
		{
			Console.WriteLine("Ignored...");
		}

		public override void SelectValue()
		{
			DateTime selectedDate = clockSetup.SelectedDate;
			Console.WriteLine("Date set to: " + selectedDate);
		}

		public override string Instructions
		{
			get
			{
				return "Press knob to view selected date...";
			}
		}

		public override int SelectedValue
		{
			get
			{
				throw new System.NotSupportedException("Clock setup finished");
			}
		}

	}
}
