using System;

namespace TaskThree
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Compares two char arrays lexicographically \nand finds which one is first.");
			//Assigning the values of the first array entered from the keyboard as a string
			Console.Write ("Enter the first string of chars:");
			string firstString = Console.ReadLine ();

			char[] firstArray;
			firstArray = new char[firstString.Length];

			for (int i=0; i<firstString.Length; i++) {
				firstArray [i] = firstString [i];
			}

			//Assigning the values of the second array entered from the keyboard as a string
			Console.Write ("\nEnter the second string of chars:");
			string secondString = Console.ReadLine ();

			char[] secondArray;
			secondArray = new char[secondString.Length];

			for (int i=0; i<secondString.Length; i++) {
				secondArray [i] = secondString [i];
			}

			int minLength = Math.Min (firstArray.Length, secondArray.Length);

			bool equalArrays = true; //idea taken from Internet...

			for (int i=0; i<minLength; i++) 
			{
				if (firstArray [i] == secondArray [i]) 
				{
					continue;
				}
				else
				{
					equalArrays = false;
					if (firstArray [i] > secondArray [i])
					{
						Console.WriteLine ("The second array entered is first in lexicographic order.");
					}
					else
					{
						Console.WriteLine ("The first array entered is first in lexicographic order.");
					}
					break;
				}

			}
			if ((firstArray.Length == secondArray.Length) && (equalArrays == true)) 
			{
				Console.WriteLine ("The arrays are equal.");
			} 
			else if ((firstArray.Length > secondArray.Length) && (equalArrays == true)) 
			{
				Console.WriteLine ("The second array entered is first in lexicographic order.");
			}
			else if ((firstArray.Length < secondArray.Length) && (equalArrays == true)) 
			{
				Console.WriteLine ("The first array entered is first in lexicographic order.");
			}
			Console.Write ("Press any key to exit...");
			Console.ReadKey ();
		}
	}
}
