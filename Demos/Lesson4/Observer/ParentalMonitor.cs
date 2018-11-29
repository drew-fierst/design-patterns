using System;

namespace Observer
{
	public class ParentalMonitor : ISpeedChangedListener
	{
		public const int SPEED_TO_ALERT = 70;

		public ParentalMonitor(Speedometer meter)
		{
			meter.AddListener(this);
		}

		public void SpeedChanged(int newSpeed, int oldSpeed)
		{
			if (newSpeed > SPEED_TO_ALERT)
			{
				Console.WriteLine("** ALERT ** Driving too fast! (" + newSpeed + ")");
			}
		}
	}
}
