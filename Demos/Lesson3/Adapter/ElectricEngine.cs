using System;

namespace Adapter
{
	public class ElectricEngine
	{

		private int size;

		public ElectricEngine(int size)
		{
			this.size = size;
		}

		public virtual int EngineSize
		{
			get
			{
				return size;
			}
		}

		public override string ToString()
		{
			return "ELECTRIC ENGINE " + size;
		}
	}
}
