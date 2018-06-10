using System;

namespace PrintNumbersOnToN
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			bool intParse = false;
			int intNum = 0;
			string str = null;
			while (intParse==false)
			{
				Console.WriteLine ("Please enter integer number:");
				str = Console.ReadLine();
				intParse=Int32.TryParse(str, out intNum);
			}
			for (int i=1; i <= intNum; i++)
			{
				if (i == 1)
				{
					Console.Write ("{0}",i);
				}
				else if (i==intNum)
				{
					Console.WriteLine (", {0}",i);
				}
				else
				{
					Console.Write (", {0}",i);
				}
			}
			Console.Write ("Press any key to exit...");
			Console.ReadKey();
		}
	}
}
