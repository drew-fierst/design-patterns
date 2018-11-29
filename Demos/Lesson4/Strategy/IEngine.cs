using System;

namespace Strategy
{
	public interface IEngine
	{
		int Size { get; }
		bool Turbo { get; }
	}
}
