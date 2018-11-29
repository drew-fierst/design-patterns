using System;

namespace AbstractFactory
{
	public class CarBody : IBody
	{

		public virtual string BodyParts
		{
			get
			{
				return "Body shell parts for a car";
			}
		}

	}
}
