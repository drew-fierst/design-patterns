using System;

namespace FactoryMethod
{
	public interface IEngine
	{
		int Size { get; }
		bool Turbo { get; }
	}
}
