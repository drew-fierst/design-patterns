using System;

namespace Composite
{
	public class Part : AbstractItem
	{
		public Part(string description, int cost)
				: base(description, cost)
		{
		}

		// Empty implementations for unit parts...
		public override void AddItem(AbstractItem item)
		{
		}

		public override void RemoveItem(AbstractItem item)
		{
		}

		public override AbstractItem[] Items
		{
			get
			{
				return new AbstractItem[0];
			}
		}
	}
}
