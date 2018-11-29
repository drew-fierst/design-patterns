﻿using System;

namespace AbstractFactory
{
	public class VanChassis : IChassis
	{

		public virtual string ChassisParts
		{
			get
			{
				return "Chassis parts for a van";
			}
		}

	}
}
