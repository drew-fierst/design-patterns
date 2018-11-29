using System;

namespace State
{
	public abstract class AbstractClockSetupState : IClockSetupState
	{
		protected ClockSetup clockSetup;
		protected IClockSetupState nextState;
		protected int value;

		protected int minValue;
		protected int maxValue;

		public AbstractClockSetupState(ClockSetup clockSetup)
		{
			this.clockSetup = clockSetup;
		}

		public virtual IClockSetupState NextState
		{
			get
			{
				return nextState;
			}
			set
			{
				nextState = value;
			}
		}

		public virtual void PreviousValue()
		{
			if (value > minValue)
			{
				value--;
			}
			else
			{
				value = maxValue;
			}
		}

		public virtual void NextValue()
		{
			if (value < maxValue)
			{
				value++;
			}
			else 
			{
				value = minValue;
			}
		}

		public virtual int SelectedValue
		{
			get
			{
				return value;
			}
		}

		public abstract void SelectValue();

		public abstract string Instructions { get; }

	}
}