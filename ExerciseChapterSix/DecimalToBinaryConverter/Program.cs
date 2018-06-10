using System;

namespace DecimalToBinaryConverter
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("We will convert a number from decimal to binary numeral system.");
			int decimalNum = 0;
			string strNum = null;


			bool parseTest = false;
			while (parseTest == false) 
			{
				Console.WriteLine ("Enter value in decimal numeral system:");
				strNum = Console.ReadLine ();
				parseTest = int.TryParse (strNum, out decimalNum);
			}
			strNum = Convert.ToString (decimalNum+255,2);
			Console.WriteLine (strNum);
			strNum = Convert.ToString (int.MaxValue,2);
			Console.WriteLine (strNum);
			strNum = Convert.ToString (int.MinValue,2);
			Console.WriteLine (strNum);
		
		}
	}
}
