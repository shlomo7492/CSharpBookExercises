using System;

namespace ChangeBitSequences
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("This program is to exchange the bits value of the progresive sequense of bits " +
				"with the bits of another progresive sequense");
			Console.WriteLine ("Please enter a number (integer value):");
			int aNumber = int.Parse (Console.ReadLine ());
			int tempNumber = aNumber;

			Console.WriteLine ("Please enter the starter bit position of the first bit sequence to be changed:");
			int pPos = byte.Parse (Console.ReadLine ());

			Console.WriteLine ("Please enter the starter bit position of the second bit sequence to be changed:");
			int qPos = byte.Parse (Console.ReadLine ());

			Console.WriteLine ("Please enter the range length of the sequence:");
			int k = byte.Parse (Console.ReadLine ());

			int[] firstSequence;
			firstSequence = new int[k];//sets array of bit positions of the first sequence
			int[] pTemp;
			pTemp = new int[k];// keeps the bit value of the current position of the first secuence
			int pBitChanger = 1;

			int[] secondSequence;
			secondSequence = new int[k];//sets array of bit positions of the second sequence
			int[] qTemp; 
			qTemp = new int[k];// keeps the bit value of the current position of the second secuence
			int qBitChanger = 1;


			for (byte i=1; i<=k;i++) //we just assing values here
			{
				firstSequence [i - 1] = pPos + i - 1;
				secondSequence [i - 1] = qPos + i - 1;

				pBitChanger = pBitChanger << secondSequence [i - 1];//value is returned to 1 in the end of each loop
				qBitChanger = qBitChanger << firstSequence [i - 1];
				qTemp[i - 1] = (pBitChanger & aNumber) != 0 ? 1 : 0;//temporary keeps the bit value
				pTemp[i - 1] = (qBitChanger & aNumber) != 0 ? 1 : 0;

						                                                                                                                                                                           
				pBitChanger = 1;// initialize for the next loop
				qBitChanger = 1;                                          
			}

			for (byte i=1; i<=k;i++)//we do the replasments here
			{
				qBitChanger = qBitChanger << secondSequence [i - 1];//value is returned to 1 in the end of each loop
				pBitChanger = pBitChanger << firstSequence [i - 1];

				//Console.WriteLine ("qTemp = {0}, pBitChanger={1}", qTemp[i - 1],pBitChanger);
				//Console.WriteLine ("pTemp = {0}, qBitChanger={1}", pTemp[i - 1],qBitChanger);


				if (qTemp[i - 1] == 0)
				{
					aNumber = aNumber & (~pBitChanger);//if the new bit value is '0'
				} 
				else 
				{
					aNumber = aNumber | pBitChanger; // if the new  bit value is '1'
				}
				//Console.WriteLine ("After the changes number {1}  takes new value of {0}", aNumber,tempNumber);

				if (pTemp [i - 1] == 0)
				{
					aNumber = aNumber & (~qBitChanger);//if the new bit value is '0'
				} 
				else 
				{
					aNumber = aNumber | qBitChanger; // if the new  bit value is '1'
				}

				//Console.WriteLine ("After the changes number {1}  takes new value of {0}", aNumber,tempNumber);


				pBitChanger = 1;// initialize for the next loop
				qBitChanger = 1;                                          
			}
			Console.WriteLine ("After the changes number {1}  takes new value of {0}", aNumber,tempNumber);

		}
	}
}
