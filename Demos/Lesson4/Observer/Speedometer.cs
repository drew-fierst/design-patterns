using System;
using System.Collections.Generic;

namespace Observer
{
	public class Speedometer
	{
		private int currentSpeed;
		private IList<ISpeedChangedListener> listeners;

		public Speedometer()
		{
			currentSpeed = 0;
			listeners = new List<ISpeedChangedListener>();
		}

		public virtual int CurrentSpeed
		{
			set
			{
				int oldSpeed = currentSpeed;
				//apply the change
				currentSpeed = value;
				// Tell all observers so they know value has changed...
				NotifyValueChanged(oldSpeed, currentSpeed);
			}
			get
			{
				return currentSpeed;
			}
		}

		public void AddListener(ISpeedChangedListener listener)
		{
			listeners.Add(listener);
		}

		protected void NotifyValueChanged(int oldSpeed, int newSpeed)
		{
			if (listeners.Count > 0) {
				foreach (ISpeedChangedListener oneListener in listeners)
				{
					oneListener.SpeedChanged(newSpeed, oldSpeed);
				}
			}
		}

	}
}
