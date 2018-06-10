using System;

namespace TaskEight
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = 0;
			string str = null;
			bool testParse = false;

			while (testParse==false)
			{
				Console.Write ("Enter the length of the array: ");
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
					Console.Write ("Enter value for array element {0}: ",i+1);
					str = Console.ReadLine ();
					testParse = Int32.TryParse (str, out nArray [i]);
					Console.WriteLine ();
				}
				testParse = false;
			}

			for (int i = 0; i < nArray.Length - 1; i++)
			{
				for (int j = i + 1; j < nArray.Length; j++)
				{
					if (nArray[i] > nArray[j]) // swap items
					{
						int tmp = nArray[i];
						nArray[i] = nArray[j];
						nArray[j] = tmp;
					}
				}
			}
			for (int i = 0; i < nArray.Length; i++) // print sorted array
			{
				Console.Write(nArray[i] + ", ");
			}
			Console.WriteLine ();

			Console.Write ("Press any key to exit...");
			Console.ReadKey ();
		}
	}
}
