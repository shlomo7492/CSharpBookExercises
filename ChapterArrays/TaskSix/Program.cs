using System;

namespace TaskSix
{
	class MainClass
	{
		public static void Main (string[] args)/// very weird task or atleast the example is
		{
			Console.WriteLine ("Finding the longest sequence of nonserial elements in augmentative order in array.");

			//some vars to ensure int is entered
			int elemCount = 0;
			string str = null;
			bool testParse = false;

			while (testParse==false)// checks if elemCount is integer
			{
				Console.WriteLine ("Enter the number of the array's elements (integer value):");
				str = Console.ReadLine ();
				testParse = int.TryParse (str, out elemCount);
			}
			testParse = false;

			int[] myArray;
			myArray=new int[elemCount];

			for (int i=0; i<elemCount; i++) 
			{
				while (testParse==false)// geting integer values for each element of the array
				{
					Console.WriteLine ("Enter the array's element {0}:",i);
					str = Console.ReadLine ();
					testParse = int.TryParse (str, out myArray[i]);
				}
				testParse = false;
			}
			Console.WriteLine ();
			int[] lenSeq;
			lenSeq = new int[elemCount];

			//SeqLength (lenSeq, myArray,out maxLength,out lastElem);
			//Console.WriteLine (maxLength +", "+ lastElem);
			//Console.ReadKey ();
			//LongestLeftAugmentativeSeq (lenSeq, myArray, elemCount);
			int max;
			int last;
			/*for (int i =1; i<=elemCount; i++) 
			{
				SeqLength(lenSeq, myArray,out max,out last, i);
				Console.Write("{0}-->{1}, {2}",i,max,last);
				Console.ReadKey ();
			}*/
			SeqLength(lenSeq, myArray,out max,out last, elemCount);
			for (int i =1; i<=elemCount; i++) 
			{

				Console.Write("{0}-->{1}, {2}",i,lenSeq[i-1],myArray[i-1]);
				Console.ReadKey ();
			}
		}

		// finding the maximum length of sequence (there could be more than one sequences with this length) 
		// returns the maximum sequence length, and the position of the last element of it
		public static void SeqLength(int[] len, int[] arr,out int max,out int last,int arrLen)
		{

			for (int x = 0; x < arrLen; x++)
			{
				if (x == 0) 
				{
					len [x] = 1;
				} 
				else 
				{
					int maxLength = 1;
					for (int prev = x-1; prev >= 0; prev--) 
					{
						if (arr [x] > arr[prev]) 
						{
							if (maxLength <= len [prev]) 
							{
								maxLength = len [prev] + 1;
							}
							len [x] = maxLength;
						}
						else
						{
							len [x] = maxLength;
						} 
					}
				}
			}
			max = 0;
			last = 0;
			for (int x = 0; x < arrLen; x++)
			{
				if (len [x] > max) 
				{
					max = len [x];
					last = x;
				}
			}

		}
		// Printing the longest  nonserial augmentative sequence, that is in left of all others with the same length
		public static void LongestLeftAugmentativeSeq (int[] len,int[] arr, int seqLen)
		{
			int max;
			int last;
			int currentValue = 0;
			SeqLength (len, arr, out max, out last, seqLen-1);
			int currentMax = arr [last];
			string prnString = ""+currentMax;
			Console.WriteLine (max + ";" + last + arr[last]);
			Console.ReadKey ();
			for (int x = 1;x < max-1;x++)
			{
				for (int i=len.Length-1; i<0; i--) 
				{
					if (i < last) 
					{
						if ((len [i] == max - x)&&(len [i-1] == max - x))
						{
							if ((arr [i] < currentMax)&&(arr[i-1]<currentMax))
							{
								if (arr [i] < arr [i - 1])
								{
									currentValue = arr [i - 1];
									// prnString = arr [i - 1] + ", " + prnString;
								}
								else if (arr [i] >= arr [i - 1])
								{
									currentValue = arr [i];

								}
							}
							else if (arr[i-1]>=currentMax)
							{
								currentValue = arr [i];
							}
						}
						if (currentValue != 0)
						{
							prnString = currentValue + ", " + prnString;
							currentMax = currentValue;
							currentValue = 0;
						}
					}
				}
			}



			/*int currentValue= arr[last];
			string prnString ="" + currentValue;
			int currMax = max;
			int currLast = last;
			//int i = seqLen - 1;
			while ( currLast > 0 )
			{
				SeqLength (len, arr, out max, out last, currLast-1);
				if (max < currMax) 
				{
					currMax = max;
					currentValue = arr [last];
					prnString = currentValue +", " +prnString;
					currLast = last;
				}
			}*/


			Console.WriteLine("The longest sequence is [ {0} ] ",prnString);
		}

	}
}
