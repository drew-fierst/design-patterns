using System;

namespace AbstractFactory
{
	public class VanBody : IBody
	{

		public virtual string BodyParts
		{
			get
			{
				return "Body shell parts for a van";
			}
		}

	}
}
