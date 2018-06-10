using System;

namespace TaskSeven
{
	// To find the maximu Sum of K serial elements of array with total N elements
	class MaximumSumOfKInN
	{
		public static void Main (string[] args)
		{
			int n = 0;
			string str = null;
			bool testParse = false;

			while (testParse==false)
			{
				Console.Write ("Enter value for N:");
				str = Console.ReadLine ();
				testParse = Int32.TryParse (str, out n);
				Console.WriteLine ();
			}
			testParse = false;

			int[] nArray;
			nArray = new int[n];

			for (int i=0; i<=n-1; i++) 
			{			
				while (testParse==false)
				{
					Console.Write ("Enter value for array element {0}:",i+1);
					str = Console.ReadLine ();
					testParse = Int32.TryParse (str, out nArray [i]);
					Console.WriteLine ();
				}
				testParse = false;
			}


			int k = n;


			while ((testParse==false)||(k>=n))
			{
				Console.Write ("Enter value for K (K<N):");
				str = Console.ReadLine ();
				testParse = Int32.TryParse (str, out k);
				Console.WriteLine ();
			}
			testParse = false;


			int maxSum = 0;
			int tempSum = 0;

			for (int i=0; i<=n-k; i++) 
			{
				for (int j=0; j<=k-1; j++) 
				{
					tempSum = tempSum + nArray [j+i];
				}
				if (tempSum >= maxSum) 
				{
					maxSum = tempSum;
					tempSum = 0;
				}
			}
			Console.WriteLine ("The maximum sum of k serial elements of the array is {0} \n", maxSum);
			Console.Write ("Press any key to exit...");
			Console.ReadKey ();
		}
	}
}
