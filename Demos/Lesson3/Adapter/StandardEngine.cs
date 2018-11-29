using System;

namespace Adapter
{
	public class StandardEngine : AbstractEngine
	{

		public StandardEngine(int size) : base(size, false)
		{
			// not turbocharged
		}

	}
}
