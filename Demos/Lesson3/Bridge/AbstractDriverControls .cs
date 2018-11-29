using System;

namespace Bridge
{
	public class AbstractDriverControls : IDriverControls
	{
		private IEngine engine;

		public AbstractDriverControls(IEngine engine)
		{
			this.engine = engine;
		}

		public virtual void IgnitionOn()
		{
			Console.WriteLine("Turning engine on");
			engine.Start();
		}

		public virtual void IgnitionOff()
		{
			Console.WriteLine("Turning engine off");
			engine.Stop();
		}

		public virtual void Accelerate()
		{
			Console.WriteLine("Accelerating");
			engine.IncreasePower();
		}

		public virtual void Brake()
		{
			Console.WriteLine("Slowing down");
			engine.DecreasePower();
		}

	}
}
