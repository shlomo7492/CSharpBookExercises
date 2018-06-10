using System;

namespace SumNFibonachiNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Sum of \'N\' elements of the Fibonachi sequence.");
			int numIndex = 0;
			string str = null;
			bool parseTest = false;
			while (parseTest==false) 
			{
				Console.WriteLine ("Please enter the number \'N\' of the elements of Fibonachi sequence:");
				str = Console.ReadLine ();
				parseTest = Int32.TryParse (str, out numIndex);
			}
			Console.WriteLine ("The Sum of the first {0} elements of the Fibonachi sequence is: {1}", numIndex, (FibNumElement (numIndex + 2) - 1));
			Console.Write ("Press any key to exit...");
			Console.ReadKey ();
		}
		public static int FibNumElement (int index)
			//I know that the task is for using loops but I think this is more elegant way
			// I had to do lots of paper work before that, of course...
		{
			int fibNum;
			if (index == 1)
			{
				fibNum = 0;
			} 
			else if (index == 2)
			{
				fibNum = 1;
			}
			else
			{
				fibNum = FibNumElement (index - 1) + FibNumElement (index - 2);
			}
			return fibNum;
		}
	}
}
