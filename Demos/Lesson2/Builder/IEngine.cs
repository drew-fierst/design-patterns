using System;

namespace Builder
{
	public interface IEngine
	{
		int Size { get; }
		bool Turbo { get; }
	}
}
