using System;

namespace Command
{
	public class WindowDownCommand : IVoiceCommand
	{
		private ElectricWindow window;

		public WindowDownCommand(ElectricWindow window)
		{
			this.window = window;
		}

		public virtual void Execute()
		{
			window.OpenWindow();
		}
	}
}
