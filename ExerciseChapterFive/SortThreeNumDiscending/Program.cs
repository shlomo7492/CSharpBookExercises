using System;

namespace SortThreeNumDiscending
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Please enter three real numbers!");
			float[] realNum;
			realNum = new float[3];
			float tempNum = 0f;
			bool parseTest = false;
			string ctrStr = null;
			for (int i=0; i<=(realNum.Length-1);i++)//make sure that the entered strings from the keyboard are real numbers
			{

				while (parseTest == false)
				{
					Console.WriteLine("Enter value {0}:", i+1);
					ctrStr = Console.ReadLine ();
					parseTest = float.TryParse (ctrStr, out realNum [i]);
				}
				parseTest = false;
			}
			for (int j=0; j<=(realNum.Length-1);j++)
			{
				tempNum = realNum [j];
				for (int i=j; i<=(realNum.Length-1); i++)
				{
					if (realNum[j] < realNum [i]) 
					{
						realNum[j] = realNum [i];
					} 
				}
				for (int i=j; i<=(realNum.Length-1); i++)
				{
					if (i != j) 
					{
						if (realNum[j] == realNum [i]) 
						{
							realNum [i] = tempNum;
						}
					}
			    }
				Console.WriteLine ("The discending order the {0} number is: {1}", j+1,realNum[j]);
			}
			Console.WriteLine ("Press any key to exit...");
			Console.ReadKey ();
		}
	}
}
