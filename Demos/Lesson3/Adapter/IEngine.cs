using System;

namespace Adapter
{
	public interface IEngine
	{
		int Size { get; }
		bool Turbo { get; }
	}
}
