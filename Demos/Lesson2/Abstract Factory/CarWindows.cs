using System;

namespace AbstractFactory
{
	public class CarWindows : IWindows
	{

		public virtual string WindowParts
		{
			get
			{
				return "Window glassware for a car";
			}
		}

	}
}
