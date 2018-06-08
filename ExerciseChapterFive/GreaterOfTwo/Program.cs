using System;

namespace GreaterOfTwo
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Please enter two integer values:");
			string ctrStr = null;
			bool parseTest = false;
			int first = 0;
			int second = 0;
			for (int i=1; i<=2; i++) 
			{
				while (parseTest == false) 
				{
					if (i == 1) 
					{
						Console.WriteLine ("Please enter the first value:");
						ctrStr = Console.ReadLine ();
						parseTest = Int32.TryParse (ctrStr, out first);
					} 
					else 
					{
						Console.WriteLine ("Please enter the second value:");
						ctrStr = Console.ReadLine ();
						parseTest = Int32.TryParse (ctrStr, out second);
					}
				}
				parseTest = false;
			}
			if (first > second) 
			{
				Console.WriteLine ("The first number {0} is greater than the second number {1} and we \nwill exchange their values.",first, second);
				first = first - second;//keeps diference as new value of first second+first=old value of first
				second = second + first;//making second == old value of first
				first = second - first;//now first has the old value of second
				Console.WriteLine ("Now the first number is {0} and the second number is {1}.",first, second);

			}
			else
			{
				Console.WriteLine ("The second number {1} is already greater then the first one {0}.", first, second);
			}

		}
	}
}
