using System;

namespace Iterator
{
	public interface IContainer<T>
	{
		IIterator<T> GetIterator();
		void AddItem(T item);
	}
}