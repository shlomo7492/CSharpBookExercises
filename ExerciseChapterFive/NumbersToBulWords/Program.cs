using System;

namespace NumbersToBulWords
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string str = null;
			bool test = false;
			byte digit = 10;
			while ((test==false)||(digit >= 10))
			{
				Console.WriteLine ("Please enter a digit (0-9):");
				str = Console.ReadLine ();
				test = byte.TryParse (str, out digit);
			}
			switch (digit)
			{
				case 0:
					Console.WriteLine ("Нула"); break;
				case 1:
					Console.WriteLine ("Едно"); break;
				case 2:
					Console.WriteLine ("Две"); break;
				case 3:
					Console.WriteLine ("Три"); break;
				case 4:
					Console.WriteLine ("Четири"); break;
				case 5:
					Console.WriteLine ("Пет"); break;
				case 6:
					Console.WriteLine ("Шест"); break;
				case 7:
					Console.WriteLine ("Седем"); break;
				case 8:
					Console.WriteLine ("Осем"); break;
				case 9:
					Console.WriteLine ("Девет"); break;
				default:
					Console.WriteLine ("I don't know what to say..."); break;

			}
			Console.WriteLine ("Press any key to exit...");
			Console.ReadKey ();
		}
	}
}
