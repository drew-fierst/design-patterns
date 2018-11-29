using System;

namespace Command
{
	public class VolumeUpCommand : IVoiceCommand
	{
		private Radio radio;

		public VolumeUpCommand(Radio radio)
		{
			this.radio = radio;
		}

		public virtual void Execute()
		{
			radio.VolumeUp();
		}
	}
}
