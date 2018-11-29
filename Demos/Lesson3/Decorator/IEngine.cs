using System;

namespace Decorator
{
	public interface IEngine
	{
		int Size { get; }
		bool Turbo { get; }
	}
}
