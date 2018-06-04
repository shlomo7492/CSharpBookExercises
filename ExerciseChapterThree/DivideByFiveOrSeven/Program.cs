using System;

namespace DivideByFiveOrSeven
{

		class FiveAndSeven
		{
			public static void Main (string[] args)
			{
				Console.WriteLine ("Pleace enter an integer number:");
				int enteredNum = int.Parse (Console.ReadLine ());
				bool divWithoutReminder = ((enteredNum % 5) == 0) && ((enteredNum % 7) == 0);
	 				
				if (divWithoutReminder) 
				{
					Console.WriteLine ("The entered number {0} is successfuly divided by 5 and by 7 without reminder.", enteredNum);
				} 
				else 
				{
					Console.WriteLine ("The entered number {0} can not be divided by 5 and by 7 without reminder.", enteredNum);
				}
			}
		}
}
