using System;

namespace Decorator
{
	public class TurboEngine : AbstractEngine
	{

		public TurboEngine(int size) : base(size, true)
		{
			// turbocharged
		}

	}
}
