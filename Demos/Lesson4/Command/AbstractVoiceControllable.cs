using System;

namespace Command
{
	public abstract class AbstractVoiceControllable
	{
		protected IVoiceCommand upCommand;
		protected IVoiceCommand downCommand;

		public IVoiceCommand UpCommand
		{
			get
			{
				return upCommand;
			}
		}

		public IVoiceCommand DownCommand
		{
			get
			{
				return downCommand;
			}
		}

	}
}