using System;

namespace Command
{
	public class WindowUpCommand : IVoiceCommand
	{
		private ElectricWindow window;

		public WindowUpCommand(ElectricWindow window)
		{
			this.window = window;
		}

		public virtual void Execute()
		{
			window.CloseWindow();
		}
	}
}
