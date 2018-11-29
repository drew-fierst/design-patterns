using System;

namespace Adapter
{
	public class TurboEngine : AbstractEngine
	{

		public TurboEngine(int size) : base(size, true)
		{
			// turbocharged
		}

	}
}
