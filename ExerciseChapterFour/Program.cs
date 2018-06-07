using System;

namespace DivToFiveInRange
{
	class DivByFive
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("This program will prints the number of the values \nwhich can be divaded by 5 without reminder  \nin the range of two integer numbers.");
			Console.WriteLine ("Please enter the first integer number:");
			int firstNum = Int32.Parse (Console.ReadLine ());
			Console.WriteLine ("Please enter the second integer number:");
			int secondNum = Int32.Parse (Console.ReadLine ());
			int countNum = 0;
			while (firstNum<secondNum) 
			{
				firstNum++;
				if ((firstNum % 5) == 0) 
				{
					countNum++;
				}
			}
			Console.WriteLine ("The number of values that can be divided by 5 without reminder is {0}", countNum);
		}
	}
}
