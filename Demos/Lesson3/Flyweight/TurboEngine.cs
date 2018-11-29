using System;

namespace Flyweight
{
	public class TurboEngine : AbstractEngine
	{

		public TurboEngine(int size) : base(size, true)
		{
			// turbocharged
		}

	}
}
