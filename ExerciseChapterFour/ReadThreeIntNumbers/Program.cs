using System;

namespace ReadThreeIntNumbers
{
	class ReadIntegers
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Please, enter three integer numbers:");
			Console.Write ("First integer:");
			int first = Int32.Parse (Console.ReadLine ());
			Console.Write ("Second integer:");
			int second = Int32.Parse (Console.ReadLine ());
			Console.Write ("Third integer:");
			int third = Int32.Parse (Console.ReadLine ());
			Console.WriteLine ("The sum of the three entered numbers is {0}", (first + second + third));
		}
	}
}
