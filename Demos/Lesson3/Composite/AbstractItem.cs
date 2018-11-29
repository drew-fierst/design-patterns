using System;

namespace Composite
{
	public abstract class AbstractItem
	{
		private string description;
		private int cost;

		public AbstractItem(string description, int cost)
		{
			this.description = description;
			this.cost = cost;
		}

		public virtual string Description
		{
			get
			{
				return description;
			}
		}

		public virtual int Cost
		{
			get
			{
				return cost;
			}
		}

		public abstract void AddItem(AbstractItem item);
		public abstract void RemoveItem(AbstractItem item);
		public abstract AbstractItem[] Items { get; }

		public override string ToString()
		{
			return description + " (cost " + Cost + ")";
		}

	}
}
