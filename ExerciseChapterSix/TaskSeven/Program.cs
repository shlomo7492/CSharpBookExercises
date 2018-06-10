using System;

namespace TaskSeven
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("We will calculate \'N!*K!/(N-K)!\', with N>K>1");
			int n = 0;
			int k = 0;
			string str = null;
			bool parseTest = false;
			while (n <= k) 
			{
				while ((parseTest == false)||(n <= 1))
				{
					Console.WriteLine ("Enter integer value for \'N\':");
					str = Console.ReadLine ();
					parseTest = Int32.TryParse (str, out n);
				}
				parseTest = false;
				while ((parseTest == false)||(k <= 1))
				{
					Console.WriteLine ("Enter integer value for \'K\':");
					str = Console.ReadLine ();
					parseTest = Int32.TryParse (str, out k);
				}
				parseTest = false;
			}
			Console.WriteLine ("{0}!*{1}!= ({0}-{1})! is {2}", n, k, (Factorial (n) * Factorial (k))/Factorial(n-k));
			Console.Write ("Press any key to exit...");
			Console.ReadKey ();
		}
		public static int Factorial (int n)
		{
			int nFact = 1;
			for (int i=1; i<=n; i++) 
			{
				nFact = nFact * i;
			}
			return nFact;
		}
	}
}
