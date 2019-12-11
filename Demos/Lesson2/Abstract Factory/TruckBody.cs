using System;

namespace AbstractFactory
{
	public class TruckBody : IBody
	{

		public virtual string BodyParts
		{
			get
			{
				return "Body shell parts for a truck";
			}
		}

	}
}
