using System;

namespace Memento
{
	public class CruiseControl
	{
		private Speedometer meter;
		private SpeedometerMemento settings;

		public CruiseControl(Speedometer meter)
		{
			this.meter = meter;
			settings = null;
		}

		public void Set()
		{
			settings = meter.CreateMemento();
		}

		public void Resume()
		{
			if (settings != null)
			{
				meter.RestoreState(settings);
			}
		}

	}
}