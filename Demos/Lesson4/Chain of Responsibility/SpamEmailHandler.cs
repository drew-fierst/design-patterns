﻿using System;

namespace Chain
{
	public class SpamEmailHandler : AbstractEmailHandler
	{
		protected internal override string[] MatchingWords()
		{
			return new string[] { "viagra", "pills", "medicines" };
		}

		protected internal override void HandleHere(string email)
		{
			Console.WriteLine("This is a spam email.");
		}
	}
}
