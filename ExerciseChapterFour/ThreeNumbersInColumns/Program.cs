using System;

namespace ThreeNumbersInColumns
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter three numbers:");
			Console.Write ("First:");
			int first = int.Parse (Console.ReadLine ());
			Console.Write ("Second:");
			float second = float.Parse (Console.ReadLine ());
			float third=1f;
			while ( third > 0)
			{
				Console.Write ("Third (negative number):");
				third = float.Parse (Console.ReadLine ());
			}
			Console.WriteLine ("{0,-10}{1,-10}{2,-10}", "First:", "Second:", "Third:");
			Console.WriteLine ("{0,-10:x}{1,-10:f2}{2,-10:f2}", first, second, third);
		}
	}
}
