using System;

namespace Command
{
	public class ElectricWindow : AbstractVoiceControllable
	{
		private bool open;

		public ElectricWindow()
		{
			this.upCommand = new WindowUpCommand(this);
			this.downCommand = new WindowDownCommand(this);
			
			open = false;
			Console.WriteLine("Window is closed");
		}

		public virtual bool Open
		{
			get
			{
				return open;
			}
		}

		public virtual bool Closed
		{
			get
			{
				return (!open);
			}
		}

		public virtual void OpenWindow()
		{
			if (Closed)
			{
				open = true;
				Console.WriteLine("Window is now open");
			}
		}

		public virtual void CloseWindow()
		{
			if (Open)
			{
				open = false;
				Console.WriteLine("Window is now closed");
			}
		}

	}
}
