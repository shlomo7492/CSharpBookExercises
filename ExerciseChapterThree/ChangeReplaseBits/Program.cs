using System;

namespace ChangeReplaseBits
{
	class ChangeThreeBits
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Please enter a number (integer value):");
			int aNumber = int.Parse (Console.ReadLine ());
			int tempNumber = aNumber;

			byte[] changePos;
			changePos = new byte[3];
			byte[] takePosVal;
			takePosVal = new byte[3];
			int temp = 0;
			int tempPos = 1;

			for (byte i=1; i<=3;i++)
			{
				Console.WriteLine ("Please enter the bit position {0} you want to make changes to:", i);

				changePos [i-1] = byte.Parse (Console.ReadLine ());
				Console.WriteLine ("Please enter the bit position {0} you want to take values from:", i);

				takePosVal [i-1] = byte.Parse (Console.ReadLine ());
				tempPos = tempPos << takePosVal [i - 1];//value is returned to 1 in the end of each loop
				temp = (tempPos & aNumber) != 0 ? 1 : 0;
				//Console.WriteLine ("temp = {0}, tempPosToChg={1}", temp,tempPos);

				if (takePosVal [i - 1] > changePos [i - 1]) //checks if the position of the bit to be changed is greater or smaller than the replasement one
				{
					tempPos = tempPos >> (takePosVal [i - 1] - changePos [i - 1]);
				}
				else
				{
					tempPos = tempPos << (changePos [i - 1] -  takePosVal [i - 1]);
				}

				//Console.WriteLine ("temp = {0}, tempPosToChg={1}", temp,tempPos);

				if (temp == 0) 
				{
					aNumber = aNumber & (~tempPos);//if the new bit value is '0'
				} 
				else 
				{
					aNumber = aNumber | tempPos; // if the new  bit value is '1'
				}



				tempPos = 1;// initialize for the next loop

			}
			Console.WriteLine ("After the changes number {1}  takes new value of {0}", aNumber,tempNumber);


		}
	}
}
