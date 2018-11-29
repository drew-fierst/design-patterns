using System;

namespace AbstractFactory
{
	public class VanWindows : IWindows
	{

		public virtual string WindowParts
		{
			get
			{
				return "Window glassware for a van";
			}
		}

	}
}
