using System;

namespace SetOfFiveSumZero
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Please enter set of FIVE numbers.");
			string strTemp = null;
			bool parseTest = false;
			int[] intSet;
			bool trueSet = false;
			intSet = new int[5];
			for (int i=0; i<=(intSet.Length-1); i++) 
			{
				while (parseTest == false) 
				{
					Console.WriteLine ("Please enter element{0} of the set:",i);
					strTemp = Console.ReadLine ();
					parseTest = int.TryParse (strTemp, out intSet [i]);
				}
				parseTest = false;
			}
			if ((intSet [0] + intSet [1] + intSet [2] + intSet [3] + intSet [4]) == 0) 
			{
				trueSet = true;
				Console.WriteLine ("The sub set of numbers with sum=0 is ({0},{1},{2},{3},{4})", intSet [0], intSet [1], intSet [2], intSet [3], intSet [4]);
			}
			if ((intSet [0] + intSet [1] + intSet [2] + intSet [3]) == 0) 
			{
				trueSet = true;
				Console.WriteLine ("The sub set of numbers with sum=0 is ({0},{1},{2},{3})", intSet [0], intSet [1], intSet [2], intSet [3]);
			} 
			if ((intSet [0] + intSet [1] + intSet [2] + intSet [4]) == 0) 
			{
				trueSet = true;
				Console.WriteLine ("The sub set of numbers with sum=0 is ({0},{1},{2},{3})", intSet [0], intSet [1], intSet [2], intSet [4]);
			}
			if ((intSet [0] + intSet [1] + intSet [3] + intSet [4]) == 0) 
			{
				trueSet = true;
				Console.WriteLine ("The sub set of numbers with sum=0 is ({0},{1},{2},{3})", intSet [0], intSet [1], intSet [3], intSet [4]);
			}
			if ((intSet [0] + intSet [2] + intSet [3] + intSet [4]) == 0) 
			{
				trueSet = true;
				Console.WriteLine ("The sub set of numbers with sum=0 is ({0},{1},{2},{3})", intSet [0], intSet [2], intSet [3], intSet [4]);
			}
			if ((intSet [0] + intSet [2] + intSet [3] + intSet [4]) == 0) 
			{
				trueSet = true;
				Console.WriteLine ("The sub set of numbers with sum=0 is ({0},{1},{2},{3})", intSet [1], intSet [2], intSet [3], intSet [4]);
			}
			if ((intSet [0] + intSet [1] + intSet [2]) == 0) 
			{
				trueSet = true;
				Console.WriteLine ("The sub set of numbers is ({0},{1},{2})", intSet [0], intSet [1], intSet [2]);
			} 
			if ((intSet [0] + intSet [1] + intSet [3]) == 0) 
			{
				trueSet = true;
				Console.WriteLine ("The sub set of numbers with sum=0 is ({0},{1},{2})", intSet [0], intSet [1], intSet [3]);
			}
			if ((intSet [0] + intSet [1] + intSet [4]) == 0) 
			{
				trueSet = true;
				Console.WriteLine ("The sub set of numbers with sum=0 is ({0},{1},{2})", intSet [0], intSet [1], intSet [4]);
			}
			if ((intSet [0] + intSet [2] + intSet [3]) == 0) 
			{
				trueSet = true;
				Console.WriteLine ("The sub set of numbers with sum=0 is ({0},{1},{2})", intSet [0], intSet [2], intSet [3]);
			}
			if ((intSet [0] + intSet [2] + intSet [4]) == 0) 
			{
				trueSet = true;
				Console.WriteLine ("The sub set of numbers with sum=0 is ({0},{1},{2})", intSet [1], intSet [2], intSet [4]);
			}
			if ((intSet [0] + intSet [3] + intSet [4]) == 0) 
			{
				trueSet = true;
				Console.WriteLine ("The sub set of numbers is ({0},{1},{2})", intSet [0], intSet [3], intSet [4]);
			} 
			if ((intSet [1] + intSet [2] + intSet [3]) == 0) 
			{
				trueSet = true;
				Console.WriteLine ("The sub set of numbers with sum=0 is ({0},{1},{2})", intSet [1], intSet [2], intSet [3]);
			}
			if ((intSet [1] + intSet [3] + intSet [4]) == 0) 
			{
				trueSet = true;
				Console.WriteLine ("The sub set of numbers with sum=0 is ({0},{1},{2})", intSet [1], intSet [3], intSet [4]);
			}
			if ((intSet [1] + intSet [2] + intSet [4]) == 0) 
			{
				trueSet = true;
				Console.WriteLine ("The sub set of numbers with sum=0 is ({0},{1},{2})", intSet [1], intSet [2], intSet [4]);
			}
			if ((intSet [2] + intSet [3] + intSet [4]) == 0) 
			{
				trueSet = true;
				Console.WriteLine ("The sub set of numbers with sum=0 is ({0},{1},{2})", intSet [2], intSet [3], intSet [4]);
			}
			if ((intSet [0] + intSet [1]) == 0) 
			{
				trueSet = true;
				Console.WriteLine ("The sub set of numbers with sum=0 is ({0},{1})", intSet [0], intSet [1]);
			}
			if ((intSet [0] + intSet [2]) == 0) 
			{
				trueSet = true;
				Console.WriteLine ("The sub set of numbers with sum=0 is ({0},{1})", intSet [0], intSet [2]);
			}
			if ((intSet [0] + intSet [3]) == 0) 
			{
				trueSet = true;
				Console.WriteLine ("The sub set of numbers with sum=0 is ({0},{1})", intSet [0], intSet [3]);
			}
			if ((intSet [0] +  intSet [4]) == 0) 
			{
				trueSet = true;
				Console.WriteLine ("The sub set of numbers with sum=0 is ({0},{1})", intSet [1], intSet [4]);
			}
			if ((intSet [1] + intSet [2]) == 0) 
			{
				trueSet = true;
				Console.WriteLine ("The sub set of numbers with sum=0 is ({0},{1})", intSet [1], intSet [2]);
			}
			if ((intSet [1] + intSet [3]) == 0) 
			{
				trueSet = true;
				Console.WriteLine ("The sub set of numbers with sum=0 is ({0},{1})", intSet [1], intSet [3]);
			}
			if ((intSet [1] + intSet [4]) == 0) 
			{
				trueSet = true;
				Console.WriteLine ("The sub set of numbers with sum=0 is ({0},{1})", intSet [1], intSet [4]);
			}
			if ((intSet [2] +  intSet [3]) == 0) 
			{
				trueSet = true;
				Console.WriteLine ("The sub set of numbers with sum=0 is ({0},{1})", intSet [2], intSet [3]);
			}
			if ((intSet [2] + intSet [4]) == 0) 
			{
				trueSet = true;
				Console.WriteLine ("The sub set of numbers with sum=0 is ({0},{1})", intSet [2], intSet [4]);
			}
			if ((intSet [3] + intSet [4]) == 0) 
			{
				trueSet = true;
				Console.WriteLine ("The sub set of numbers with sum=0 is ({0},{1})", intSet [3], intSet [4]);
			}
			if (trueSet == false)
			{
				Console.WriteLine ("There is no sub sets of numbers with sum=0.");
			}
		}
	}
}
