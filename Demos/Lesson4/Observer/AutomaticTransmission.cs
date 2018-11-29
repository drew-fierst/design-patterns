using System;

namespace Observer
{
	public class AutomaticTransmission : ISpeedChangedListener
	{
		public AutomaticTransmission(Speedometer meter)
		{
			meter.AddListener(this);
		}

		public void SpeedChanged(int newSpeed, int oldSpeed)
		{
			if (newSpeed <= 10)
			{
				Console.WriteLine("Now in first gear");

			}
			else if (newSpeed <= 25)
			{
				Console.WriteLine("Now in second gear");

			}
			else if (newSpeed <= 40)
			{
				Console.WriteLine("Now in third gear");

			}
			else if (newSpeed <= 55)
			{
				Console.WriteLine("Now in fourth gear");
			}
			else
			{
				Console.WriteLine("Now in fifth gear");
			}
		}
	}
}
