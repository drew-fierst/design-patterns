using System;

namespace Command
{
	public class VolumeDownCommand : IVoiceCommand
	{
		private Radio radio;

		public VolumeDownCommand(Radio radio)
		{
			this.radio = radio;
		}

		public virtual void Execute()
		{
			radio.VolumeDown();
		}
	}
}
