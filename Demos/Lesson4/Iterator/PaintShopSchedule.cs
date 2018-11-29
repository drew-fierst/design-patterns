using System;
using System.Collections.Generic;

namespace Iterator
{
	public class PaintShopSchedule : IIterator<PaintInstructions>
	{
		private IList<PaintInstructions> items;
		private int nextIdx;

		public PaintShopSchedule(IList<PaintInstructions> items) 
		{
			this.items = items;
			nextIdx = 0;
		}

		public bool HasNext()
		{
			return nextIdx < items.Count;
		}

		public PaintInstructions GetNext()
		{
			if (nextIdx >= items.Count) return null;

			return items[nextIdx++];
		}

	}
}