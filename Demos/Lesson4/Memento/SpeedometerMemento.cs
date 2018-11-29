using System;

namespace Memento
{
	public class SpeedometerMemento
	{
		private int currentSpeed;

		public SpeedometerMemento(int speed)
		{
			currentSpeed = speed;
		}

		public int CurrentSpeed
		{
			get
			{
				return currentSpeed;
			}
		}
	}
}
