using System;

namespace CountZeroInTheEndOfFactorial
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("We will calculate \'N!/K!\', with N>K>1");
			int n = 0;
			string str = null;
			bool parseTest = false;
			while ((parseTest == false)||(n <= 1))
			{
				Console.WriteLine ("Enter integer value for \'N\':");
				str = Console.ReadLine ();
				parseTest = Int32.TryParse (str, out n);
			}
			for (int i=1; i<=n; i++) 
			{
				Console.WriteLine ("{0}!={1} and the number of all zero digit in the end of {0}! is: {2}", i, Factorial (i),ZeroCount(Factorial(i)));
			}

			Console.Write ("Press any key to exit...");
			Console.ReadKey ();
		}
		public static ulong Factorial (int n)
		{
			ulong nFact = 1;
			for (int i=1; i<=n; i++) 
			{
				nFact = nFact * (ulong)i;
			}
			return nFact;
		}
		public static int ZeroCount(ulong n)
		{
			string strFact = Convert.ToString(n);
			string strTmp = "0";
			int countZero = 0;
			int endDigitsCount=strFact.Length-1;
			while (strTmp == "0") 
			{
				strTmp =""+strFact [endDigitsCount];
				if (strTmp == "0")
				{
					countZero++;
				}
				endDigitsCount--;
			}

			return countZero;
		}
	}
}
