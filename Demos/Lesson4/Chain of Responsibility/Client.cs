using System;

namespace Chain
{
	public class Client
	{
		static void Main()
		{
			Console.WriteLine();

			// Create the handler objects...
			IEmailHandler mailFilter = new SpamEmailHandler();
			IEmailHandler sales = new SalesEmailHandler();
			IEmailHandler service = new ServiceEmailHandler();
			IEmailHandler manager = new ManagerEmailHandler();
			IEmailHandler general = new GeneralInquiriesEmailHandler();

			// Chain them together...
			mailFilter.NextHandler = sales;
			sales.NextHandler = service;
			service.NextHandler = manager;
			manager.NextHandler = general;

			string email = "I need my car repaired";
			mailFilter.ProcessMessage(email);

			email = "Cheap Canadian pills";
			mailFilter.ProcessMessage(email);

			email = "I want you to repair my product";
			mailFilter.ProcessMessage(email);

			email = "I would like some information about your services";
			mailFilter.ProcessMessage(email);

			email = "This complaint is about one of your employees";
			mailFilter.ProcessMessage(email);

			Console.ReadLine();
		}
	}
}
