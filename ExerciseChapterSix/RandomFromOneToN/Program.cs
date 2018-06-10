using System;

namespace RandomFromOneToN
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			int numRange = 0;
			string str = null;
			bool testPar = false;
			while (testPar==false) 
			{
				Console.WriteLine ("Enter integer number\'N\':");
				str = Console.ReadLine ();
				testPar = int.TryParse (str, out numRange);
			}
			int prnNum = 0;
			int[] setNum;
			Random rnd = new Random ();
			setNum = new int[numRange+1];
			for (int i=0;i<=numRange-1;i++) 
			{
				while (prnNum==0) 
				{
					prnNum = rnd.Next (1,numRange+1);
					foreach (int valNum in setNum) 
					{
						if (prnNum == valNum) 
						{
							prnNum = 0;
						}
					}
				}

				if (prnNum != 0) 
				{
					setNum [i] = prnNum;
				}
				Console.WriteLine ("Position {0} is number{1}", i+1, setNum [i]);
				prnNum = 0;
			}
		}
	}
}
