using System;

namespace NumbersOfCatalan
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("We will calculate \'Cn\' (Catalan's numbers), for each n>=0 entered from the keyboard.");
			int n = 0;
			string str = null;
			bool parseTest = false;
			while ((parseTest == false)||(n < 0))
			{
				Console.WriteLine ("Enter integer value for \'N\':");
				str = Console.ReadLine ();
				parseTest = Int32.TryParse (str, out n);
			}
			Console.WriteLine ("C{0} is {1}", n, Factorial (2*n) / (Factorial (n+1)*Factorial(n)));
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
