using System;

namespace PrintPlayCards
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] cardColor;
			cardColor = new string[] { "Diamonds", "Hearts", "Clubs", "Spades" };
			string[] cardNumber;
			cardNumber = new string[] { "2", "3", "4", "5", "6","7","8","9","10","Jack","Queen","King","Ace"};
			Console.WriteLine ("Printing all cards: ");
			for (int i=0; i<=3; i++) 
			{
				Console.WriteLine ("\'{0}\':", cardColor [i]);
				for (int j=0; j<=12; j++) 
				{
					Console.WriteLine ("The \'{0}\' of \'{1}\'.", cardNumber [j], cardColor [i]);
				}
				Console.Write ("Press any key to contunue...");
				Console.ReadKey ();
			}
			Console.Write ("Press any key to exit...");
			Console.ReadKey ();
		}
	}
}
