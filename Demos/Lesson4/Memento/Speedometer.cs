using System;

namespace Memento
{
	public class Speedometer
	{
		private int currentSpeed;

		public Speedometer()
		{
			currentSpeed = 0;
		}

		public virtual int CurrentSpeed
		{
			set
			{
				currentSpeed = value;
			}
			get
			{
				return currentSpeed;
			}
		}

		public SpeedometerMemento CreateMemento()
		{
			return new SpeedometerMemento(currentSpeed);
		}

		public void RestoreState(SpeedometerMemento memento)
		{
			CurrentSpeed = memento.CurrentSpeed;
		}

	}
}
