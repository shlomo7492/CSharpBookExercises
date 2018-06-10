using System;

namespace MinAndMaxInSequenceOfNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			bool intParse = false;
			int intNum = 0;
			string str = null;

			while (intParse == false) 
			{ 
				Console.WriteLine ("Please enter the length of the sequence of numbers:");
				str = Console.ReadLine ();
				intParse = Int32.TryParse (str, out intNum);
			}
			int maxInt = 0;
			int minInt = 0;
			int entInt = 0;
			intParse = false;
			for (int i=0; i<= intNum-1; i++) 
			{ 
				while (intParse==false)
				{
					Console.WriteLine ("Please enter the {0} number:",i);
					str = Console.ReadLine ();
					intParse = Int32.TryParse (str, out entInt);
					if ((i == 0) && (intParse == true)) 
					{
						maxInt = entInt;
						minInt = entInt;
					} 
					else if ((i != 0) && (intParse == true)) 
					{
						if (maxInt <= entInt) 
						{
							maxInt = entInt;
						}
						if (minInt >= entInt) 
						{
							minInt = entInt;
						}
					}
				}
				intParse = false;
			}
			Console.WriteLine ("Min number is {0} and max number is {1}", minInt, maxInt);
			Console.Write ("Press any key to exit...");
			Console.ReadKey ();
		}
	}
}
