using System;

namespace SequenceSumTaskEight
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = 0;
			int x = 0;
			string str = null;
			bool parseTest = false;
			while ((parseTest == false)||(n <= 0))
			{
				Console.WriteLine ("Enter integer value \'N\'for the length of the sequence:");
				str = Console.ReadLine ();
				parseTest = Int32.TryParse (str, out n);
			}
			while ((parseTest == false)||(x <= 0))
			{
				Console.WriteLine ("Enter integer value \'X\':");
				str = Console.ReadLine ();
				parseTest = Int32.TryParse (str, out x);
			}
			Console.WriteLine ("S{0} is {1}", n, SequenceSum(x,n));
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
		public static double SequenceSum(int n, int x)
		{
			double nSum = 1;
			for (int i=1; i<=n; i++) 
			{
				nSum = nSum + ((double)Factorial (i)) / ((long)Math.Pow (x, i));
				Console.WriteLine ("{0}, {1}", nSum, (long)Math.Pow (x, i));
			}
			return nSum;
		}
	}
}
