using System;

namespace Command
{
	public class Client
	{
		static void Main()
		{
			Console.WriteLine();

			// Create a radio and its up/down command objects
			Radio radio = new Radio();
			radio.SwitchOn();

			// Create an electric window and its up/down command objects
			ElectricWindow window = new ElectricWindow();

			// Create a speech recogniser object to manage the radio and window
			SpeechRecognizer speechRecognizer = new SpeechRecognizer(radio, window);

			speechRecognizer.HearRadioSpoken();
			Console.WriteLine("Speech recognition controlling the radio");
			speechRecognizer.HearUpSpoken();
			speechRecognizer.HearUpSpoken();
			speechRecognizer.HearUpSpoken();
			speechRecognizer.HearDownSpoken();

			speechRecognizer.HearWindowSpoken();
			Console.WriteLine("Speech recognition will now control the window");
			speechRecognizer.HearDownSpoken();
			speechRecognizer.HearUpSpoken();

			Console.ReadLine();
		}
	}
}
