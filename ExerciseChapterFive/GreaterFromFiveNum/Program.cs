using System;

namespace GreaterFromFiveNum
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Please enter three real numbers!");
			float[] realNum;
			realNum = new float[5];
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

				if (greaterNum < realNum [i]) 
				{
					greaterNum = realNum [i];
				}
			}
		
			Console.WriteLine ("The grater number is {0}", greaterNum);
			Console.WriteLine ("Press any key to exit...");
			Console.ReadKey ();
		}
	}
}
