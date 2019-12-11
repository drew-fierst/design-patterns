using System;

namespace AbstractFactory
{
	public class TruckWindows : IWindows
	{

		public virtual string WindowParts
		{
			get
			{
				return "Window glassware for a truck";
			}
		}

	}
}
