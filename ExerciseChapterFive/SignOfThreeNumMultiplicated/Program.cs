using System;

namespace SignOfThreeNumMultiplicated
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Please enter three real numbers!");
			float[] realNum;
			realNum = new float[3];
			bool parseTest = false;
			bool numSign = false;// true for minus, false for plus
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
			if (realNum [0] < 0)
			{
				if (realNum[1]<0)
				{
					if (realNum[2]<0)// minus*minus*minus
					{
						numSign = true;
					}
				}
				else if (realNum[2]>0)//minus*plus*plus
				{
					numSign = true;
				}
			}
			else
			{
				if (realNum[1]<0)
				{
					if (realNum[2]>0)//plus*minus*plus
					{
						numSign = true;
					}
				}
				else if (realNum[2]<0)//plus*plus*minus
				{
					numSign = true;
				}
			}
			Console.WriteLine ("The sign of multiplication of the three real numbers is \'{0}\'.", numSign == true ? '-' : '+');
		}
	}
}
