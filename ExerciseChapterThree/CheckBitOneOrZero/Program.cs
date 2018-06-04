using System;

namespace CheckBitOneOrZero
{
	class CheckIfOne
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Please enter a number (integer value):");
			int numberToCheck = int.Parse (Console.ReadLine ());
			Console.WriteLine ("Please enter a bit position (integer value):");
			int posToPrint = int.Parse (Console.ReadLine ());
			int i = 1;
			int mask = i << posToPrint;
			bool checkedBit = (numberToCheck & mask) != 0;
			if (checkedBit) 
			{
				Console.WriteLine ("The {0} bit of number {1} is 1", posToPrint, numberToCheck);
			}
			else
			{
				Console.WriteLine ("The {0} bit of number {1} is NOT 1", posToPrint, numberToCheck);
			}
		}
	}
}

