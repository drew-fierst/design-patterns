﻿using System;

namespace Interpreter
{
	public class StandardEngine : AbstractEngine
	{

		public StandardEngine(int size) : base(size, false)
		{
			// not turbocharged
		}

	}
}
