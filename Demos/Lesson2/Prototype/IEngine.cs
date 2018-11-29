using System;

namespace Prototype
{
	public interface IEngine
	{
		int Size { get; }
		bool Turbo { get; }
		IEngine Clone();
	}
}
