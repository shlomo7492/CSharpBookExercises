using System;

namespace ChangeBitOfNumber
{
	class ChangeBit
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Please enter a number (integer value):");
			int aNumber = int.Parse (Console.ReadLine ());
			int tempNumber = aNumber;

			Console.WriteLine ("Please enter the bit position you want to change:");
			byte digPosition = byte.Parse (Console.ReadLine ());

			byte v = 2;
			while (!((v==0)||(v==1)))
			{
				Console.WriteLine ("Please enter the new bit value for {0} position (0 or 1):", digPosition);
				v = byte.Parse (Console.ReadLine ());
			}

			int bitChanger = 1;
			bitChanger = bitChanger << digPosition;

			if (v == 0) 
			{
				aNumber = aNumber & (~bitChanger);
				Console.WriteLine ("The new value of {0} is: {1}", tempNumber,aNumber);
			} 
			else 
			{
				aNumber = aNumber | bitChanger;
				Console.WriteLine ("The new value of {0} is: {1}", tempNumber,aNumber);
			}

		}
	}
}
