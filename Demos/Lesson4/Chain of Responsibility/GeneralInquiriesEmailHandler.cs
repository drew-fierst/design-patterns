using System;

namespace Chain
{
	public class GeneralInquiriesEmailHandler : AbstractEmailHandler
	{
		protected internal override string[] MatchingWords()
		{
			return new string[0]; // match anything
		}

		protected internal override void HandleHere(string email)
		{
			Console.WriteLine("Email handled by general enquires.");
		}
	}
}
