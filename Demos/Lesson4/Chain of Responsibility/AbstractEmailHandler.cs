using System;

namespace Chain
{
	public abstract class AbstractEmailHandler : IEmailHandler
	{
		private IEmailHandler nextHandler;

		public virtual IEmailHandler NextHandler
		{
			set
			{
				nextHandler = value;
			}
		}

		public virtual void ProcessMessage(string email)
		{
			bool wordFound = false;

			// If no words to match against then this object can handle
			if (MatchingWords().Length == 0)
			{
				wordFound = true;

			}
			else
			{
				// Look for any of the matching words
				foreach (string word in MatchingWords())
				{
					if (email.IndexOf(word) >= 0)
					{
						wordFound = true;
						break;
					}
				}
			}

			// Can we handle emai in this object?
			if (wordFound)
			{
				HandleHere(email);

			}
			else
			{
				// Unable to handle here so forward to next in chain
				nextHandler.ProcessMessage(email);
			}
		}

		protected internal abstract string[] MatchingWords();
		protected internal abstract void HandleHere(string email);

	}
}
