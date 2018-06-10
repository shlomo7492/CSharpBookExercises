using System;

namespace ТaskNine
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

			int maxSum = 0;
			int maxSumIndex = 0;
			int maxSumElemCount = 0;
			for (int i = 0;i < n; i++)
			{
				int tempSum;
				int index;
				tempSum = MaxSumOfKElem (nArray, i+1,out index);
				if (tempSum > maxSum)
				{
					maxSum = tempSum;
					maxSumIndex = index;
					maxSumElemCount = i+1;
				}
				//Console.WriteLine ("Max {0}", nArray[i]);

			}


			Console.WriteLine ("The maximum sum of serial elements of the array is sum of {1} and it\'svalue is {0}.\n The sequence of serial elements with maximum sum is:", maxSum,maxSumElemCount);
			for (int i=0; i<maxSumElemCount; i++) 
			{
				Console.Write(nArray[i+maxSumIndex]+" ");
			}
			Console.Write ("Press any key to exit...");
			Console.ReadKey ();
		}
		//finds the maximum sum of k serial elements in the array (k<n) and returns the maximum sum and the starting index
		// to help printing the elements
		public static int MaxSumOfKElem(int [] arr,int k,out int index) 
		{
			int maxSum = 0;
			index = 0;
			for (int i=0; i<=arr.Length-k; i++) 
			{
				int tempSum = 0;
				int j=0;
				while (j <= k-1) 
				{
					tempSum = tempSum + arr [j+i];
					//Console.WriteLine ("Proba {0}-->{1}-->{2}",i+j, arr[j+i],tempSum);
					j++;
				}
				if (tempSum >= maxSum) 
				{
					maxSum = tempSum;
					tempSum = 0;
					index = i;
				}
			}
			Console.WriteLine ("Max sum of {0} elements is {1}", k, maxSum);
			return maxSum;
		}
	}
}
