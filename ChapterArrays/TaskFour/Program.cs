using System;

namespace TaskFour
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Finding the longest sequence of equal elements in array.");

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
			string[] strArray; //keeps each sequence of equal elements in each string
			strArray = new string[elemCount];

			int iterStarter = 0; //used as starting value for the nested for loop
			int iterModifier = 0; //used to modify the starting value without making mess of the cuurent loop
			string longSeq = null;
			for (int iStr=0; iStr<elemCount; iStr++) 
			{
				for (int i=iterStarter; i<elemCount; i++) 
				{
					if (i != (elemCount-1)) 
					{
						if (myArray [i] == myArray [i + 1])
						{
							strArray [iStr] = strArray [iStr] + myArray [i] + ", ";
							iterModifier++;
						} 
						else 
						{
							strArray [iStr] = strArray [iStr] + myArray [i];
							iterModifier++;
							i = elemCount + 1;
						}
					}
					else 
					{
						strArray [iStr] = strArray [iStr] + myArray [i];
						iterModifier = elemCount;
					}
				}
				iterStarter = iterModifier;
				// Console.WriteLine (strArray [iStr]+"-->" +iterModifier); this check if all above works... :D

				if (iStr == 0) 
				{
					longSeq = strArray [iStr];
				}
				else 
				{
					string currentStr ="" + strArray [iStr]; // to allow us to compare elements length
					string prevStr = "" + strArray [iStr - 1];
					int currLength = currentStr.Length;
					int prevLength = prevStr.Length;
					if (currLength > prevLength) 
					{
						longSeq = currentStr;
					}
				}
			}
			Console.Write ("The longest sequense is {0}. \n\n Press any key to exit...", longSeq);
			Console.ReadKey ();
		}
	}
}
