using System;

namespace Interpreter
{
	public interface IEngine
	{
		int Size { get; }
		bool Turbo { get; }
	}
}
