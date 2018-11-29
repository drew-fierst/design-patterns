using System;

namespace Strategy
{
	public class TurboEngine : AbstractEngine
	{

		public TurboEngine(int size) : base(size, true)
		{
			// turbocharged
		}

	}
}
