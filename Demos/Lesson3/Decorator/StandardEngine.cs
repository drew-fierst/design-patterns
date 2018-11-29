using System;

namespace Decorator
{
	public class StandardEngine : AbstractEngine
	{

		public StandardEngine(int size) : base(size, false)
		{
			// not turbocharged
		}

	}
}
