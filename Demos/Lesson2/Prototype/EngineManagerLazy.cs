using System;

namespace Prototype
{
	public class EngineManagerLazy
	{
		private IEngine smallStandard, mediumStandard, largeStandard, smallTurbo, largeTurbo;

		public IEngine GetEngine(EngineSize size, bool turbo)
		{
			if (turbo)
			{
				if (size == EngineSize.Large)
				{
					if (largeTurbo == null) largeTurbo = new TurboEngine(2000);
					return largeTurbo.Clone();
				}
				else
				{
					if (smallTurbo == null) smallTurbo = new TurboEngine(1800);
					return smallTurbo.Clone();
				}
			}
			else
			{
				if (size == EngineSize.Large)
				{
					if (largeStandard == null) largeStandard = new StandardEngine(1800);
					return largeStandard.Clone();
				}
				else if (size == EngineSize.Medium)
				{
					if (mediumStandard == null) mediumStandard = new StandardEngine(1500);
					return mediumStandard.Clone();
				}
				else
				{
					if (smallStandard == null) smallStandard = new StandardEngine(1200);
					return smallStandard.Clone();
				}
			}
		}
	}
}