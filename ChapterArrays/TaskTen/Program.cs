using System;

namespace TaskTen
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = 0;
			string str = null;
			bool testNum = false;
			while (testNum==false) 
			{
				Console.Write ("Enter the number of the array elements N=");
				str = Console.ReadLine ();
				testNum = int.TryParse (str, out n);
				Console.WriteLine ();
			}

			int[] nArray;
			nArray = new int[n];

			for (int i=0; i<n; i++) 
			{
				testNum = false;

				while (testNum==false) 
				{
					Console.Write ("Enter the {0} element of the array:",i);
					str = Console.ReadLine ();
					testNum = int.TryParse (str, out nArray[i]);
					Console.WriteLine ();
				}

			}

			int maxAmount = 0;

			int maxNumOfElement = 0;;

			for (int i=0; i<n; i++) 
			{
				int currentAmount = 0;
				int currentNumOfElement = nArray[i];

				for (int j=i; j<n; j++)
				{
					if ((currentNumOfElement == nArray [j]) && (nArray [j] != int.MinValue)) 
					{
						currentAmount++;
						nArray [j] = int.MinValue;
					}
				}
				if (currentAmount > maxAmount) 
				{
					maxAmount = currentAmount;
					maxNumOfElement = currentNumOfElement;
				}
			}
			Console.WriteLine ("The maximum number elements of the array that have the same value is {0}, and the value is {1}",maxAmount,maxNumOfElement);
			Console.Write ("Press any key to exit...");
			Console.ReadKey ();
		}
	}
}
