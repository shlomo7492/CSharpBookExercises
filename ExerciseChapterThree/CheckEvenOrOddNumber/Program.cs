using System;

namespace CheckEvenOrOddNumber
{
	class EvenOrOdd
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Pleace enter an even integer number:");
			long enteredNumber = long.Parse (Console.ReadLine ());
			while ((enteredNumber%2) != 0) 
			{
				Console.WriteLine ("The entered number is odd and it is not even, pleace enter a valid even number:");
				enteredNumber = long.Parse (Console.ReadLine ());
			}
			Console.WriteLine ("Good job! Now the entered number {0} is even", enteredNumber);
		}
	}
}
