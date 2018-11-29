using System;

namespace Observer
{
	public interface ISpeedChangedListener
	{
		void SpeedChanged(int newSpeed, int oldSpeed);
	}
}