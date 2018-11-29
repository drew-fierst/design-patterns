using System;
using System.Collections.Generic;

namespace Iterator
{
	public class PaintShop : IContainer<PaintInstructions>
	{
		private IList<PaintInstructions> items;

		public PaintShop()
		{
			items = new List<PaintInstructions>();
		}

		public void AddItem(PaintInstructions instructions)
		{
			items.Add(instructions);
		}

		public IIterator<PaintInstructions> GetIterator()
		{
			return new PaintShopSchedule(items);
		}
	}
}