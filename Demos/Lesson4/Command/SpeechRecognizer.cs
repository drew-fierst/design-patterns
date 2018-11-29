using System;

namespace Command
{
	public class SpeechRecognizer
	{
		private AbstractVoiceControllable currentControllable;
		private AbstractVoiceControllable radio, window;

		public SpeechRecognizer(Radio radio, ElectricWindow window)
		{
			this.radio = radio;
			this.window = window;
		}

		public virtual void HearRadioSpoken()
		{
			currentControllable = radio;
		}

		public virtual void HearWindowSpoken()
		{
			currentControllable = window;
		}

		public virtual void HearUpSpoken()
		{
			if (currentControllable != null) currentControllable.UpCommand.Execute();
		}

		public virtual void HearDownSpoken()
		{
			if (currentControllable != null) currentControllable.DownCommand.Execute();
		}
	}
}
