using System;

namespace State
{
	public class ClockSetup
	{
		// The various states the setup can be in...
		private IClockSetupState yearState;
		private IClockSetupState monthState;
		private IClockSetupState dayState;
		private IClockSetupState hourState;
		private IClockSetupState minuteState;
		private IClockSetupState finishedState;

		// The current state we are in...
		private IClockSetupState currentState;

		public ClockSetup()
		{
			yearState = new YearSetupState(this);
			monthState = new MonthSetupState(this);
			dayState = new DaySetupState(this);
			hourState = new HourSetupState(this);
			minuteState = new MinuteSetupState(this);
			finishedState = new FinishedSetupState(this);

			yearState.NextState = monthState;
			monthState.NextState = dayState;
			dayState.NextState = hourState;
			hourState.NextState = minuteState;
			minuteState.NextState = finishedState;

			// Initial state is set to the year
			State = yearState;
		}

		public virtual IClockSetupState State
		{
			set
			{
				currentState = value;
				Console.WriteLine(currentState.Instructions);
			}
		}

		public virtual void RotateKnobLeft()
		{
			currentState.PreviousValue();
		}

		public virtual void RotateKnobRight()
		{
			currentState.NextValue();
		}

		public virtual void PushKnob()
		{
			currentState.SelectValue();
		}

		public virtual IClockSetupState YearSetupState
		{
			get
			{
				return yearState;
			}
		}

		public virtual IClockSetupState MonthSetupState
		{
			get
			{
				return monthState;
			}
		}

		public virtual IClockSetupState DaySetupState
		{
			get
			{
				return dayState;
			}
		}

		public virtual IClockSetupState HourSetupState
		{
			get
			{
				return hourState;
			}
		}

		public virtual IClockSetupState MinuteSetupState
		{
			get
			{
				return minuteState;
			}
		}

		public virtual IClockSetupState FinishedSetupState
		{
			get
			{
				return finishedState;
			}
		}

		public virtual DateTime SelectedDate
		{
			get
			{
				return new DateTime(yearState.SelectedValue,
														monthState.SelectedValue,
														dayState.SelectedValue,
														hourState.SelectedValue,
														minuteState.SelectedValue,
														0);
			}
		}

	}
}
