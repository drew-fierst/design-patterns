using System;

namespace Chain
{
	public interface IEmailHandler
	{
		IEmailHandler NextHandler { set; }
		void ProcessMessage(string email);
	}
}
