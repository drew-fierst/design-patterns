using System;

namespace Prototype
{
	public class EngineManager
	{
		private IEngine smallStandard, mediumStandard, largeStandard, smallTurbo, largeTurbo;

		public EngineManager() 
		{
			smallStandard = new StandardEngine(1200);
			mediumStandard = new StandardEngine(1500);
			largeStandard = new StandardEngine(1800);
			smallTurbo = new TurboEngine(1800);
			largeTurbo = new TurboEngine(2000);
		}

		public IEngine GetEngine(EngineSize size, bool turbo)
		{
			if (turbo)
			{
				if (size == EngineSize.Large)
					return largeTurbo.Clone();
				else
					return smallTurbo.Clone();
			}
			else
			{
				if (size == EngineSize.Large)
					return largeStandard.Clone();
				else if (size == EngineSize.Medium)
					return mediumStandard.Clone();
				else
					return smallStandard.Clone();
			}
		}
		

	}
}