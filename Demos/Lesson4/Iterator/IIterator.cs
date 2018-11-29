using System;

namespace Iterator
{
	public interface IIterator<T>
	{
		bool HasNext();
		T GetNext();
	}
}