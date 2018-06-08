using System;

namespace GreaterFromThree
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Please enter three real numbers!");
			float[] realNum;
			realNum = new float[3];
			float greaterNum = 0f;
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
			if (realNum [0] < realNum [1]) 
			{
				greaterNum = realNum [1];
			}
			else
			{
				greaterNum = realNum [0];
			}
			if (greaterNum < realNum [2]) 
			{
				greaterNum = realNum [2];
			}
			Console.WriteLine ("The grater number is {0}", greaterNum);
			Console.WriteLine ("Press any key to exit...");
			Console.ReadKey ();
		}
	}
}
