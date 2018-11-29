using System;

namespace Command
{
	public class Radio : AbstractVoiceControllable
	{
		public const int MinVolume = 0;
		public const int MaxVolume = 10;
		public const int DefaultVolume = 5;

		private bool switchedOn;
		private int volume;

		public Radio()
		{
			this.upCommand = new VolumeUpCommand(this);
			this.downCommand = new VolumeDownCommand(this);
			
			switchedOn = false;
			volume = DefaultVolume;
		}

		public virtual bool On
		{
			get
			{
				return switchedOn;
			}
		}

		public virtual int Volume
		{
			get
			{
				return volume;
			}
		}

		public virtual void SwitchOn()
		{
			switchedOn = true;
			Console.WriteLine("Radio now on, volume level " + Volume);
		}

		public virtual void SwitchOff()
		{
			switchedOn = false;
			Console.WriteLine("Radio now off");
		}

		public virtual void VolumeUp()
		{
			if (On)
			{
				if (Volume < MaxVolume)
				{
					volume++;
					Console.WriteLine("Volume turned up to level " + Volume);
				}
			}
		}

		public virtual void VolumeDown()
		{
			if (On)
			{
				if (Volume > MinVolume)
				{
					volume--;
					Console.WriteLine("Volume turned down to level " + Volume);
				}
			}
		}

	}
}
