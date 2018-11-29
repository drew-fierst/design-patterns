using System;

namespace Adapter
{
	public class ElectricEngineAdapter : AbstractEngine
	{
		private ElectricEngine engine;

		public ElectricEngineAdapter(ElectricEngine greenEngine)
				: base(greenEngine.EngineSize, false)
		{
			engine = greenEngine;
		}

		public override string ToString()
		{
			//delegate to adapted class' implementation
			return engine.ToString();
		}
	}
}
