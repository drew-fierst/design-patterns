using System.Collections.Generic;
using System.Linq;

namespace Composite
{
	public class Assembly : AbstractItem
	{
		private IList<AbstractItem> items;

		public Assembly(string description)
				: base(description, 0)
		{
			items = new List<AbstractItem>();
		}

		public override void AddItem(AbstractItem item)
		{
			items.Add(item);
		}

		public override void RemoveItem(AbstractItem item)
		{
			items.Remove(item);
		}

		public override AbstractItem[] Items
		{
			get
			{
				return items.ToArray();
			}
		}

		public override int Cost
		{
			get
			{
				int total = 0;
				foreach (AbstractItem item in items)
				{
					total += item.Cost;
				}
				return total;
			}
		}

	}
}
