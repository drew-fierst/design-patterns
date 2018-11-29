using System;

namespace Bridge
{
	public class SportControls : AbstractDriverControls
	{
		public SportControls(IEngine engine) : base(engine)
		{
		}

		public override void Accelerate()
		{
			Console.WriteLine("Hold on to your hat!");
			base.Accelerate();
			base.Accelerate();
		}

		public override void Brake()
		{
			Console.WriteLine("Whoa! The police!");
			base.Brake();
			base.Brake();
		}

	}
}
