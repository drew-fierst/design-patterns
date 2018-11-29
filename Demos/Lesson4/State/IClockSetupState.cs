using System;

namespace State
{
	public interface IClockSetupState
	{
		void PreviousValue();
		void NextValue();
		void SelectValue();

		IClockSetupState NextState { get; set; }
		string Instructions { get; }
		int SelectedValue { get; }
	}
}
