using System;

namespace AlgoritmOfEvklid
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int numA = 0;
			int numB = 0;
			string strNum = null;
			bool parseTest = false;
			while (parseTest == false) 
			{
				Console.WriteLine ("Enter A=");
				strNum = Console.ReadLine ();
				parseTest = int.TryParse (strNum, out numA);
			}
			parseTest = false;
			while (parseTest == false) 
			{
				Console.WriteLine ("Enter B=");
				strNum = Console.ReadLine ();
				parseTest = int.TryParse (strNum, out numB);
			}
			if (numA == numB) 
			{
				Console.WriteLine ("The grater common divisor is:{0}", numA);
			} 
			else 
			{
				while (numA != numB) 
				{
					if (numA > numB) 
					{
						numA = numA - numB;
					}
					else
					{
						numB = numB - numA;
					}
				}
				Console.WriteLine ("The grater common divisor is:{0}", numA);
			}

		}
	}
}
