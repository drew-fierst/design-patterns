using System;

namespace FactoryMethod
{
	public class TurboEngine : AbstractEngine
	{

		public TurboEngine(int size) : base(size, true)
		{
			// turbocharged
		}

	}
}
