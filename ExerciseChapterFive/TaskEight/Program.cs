using System;

namespace TaskEight
{
	class MainClass
	{
		public static void Main (string[] args)
		{   
			string str = null;
			while ((str == null)|| ((str != "s")&&(str != "i")&&(str != "d")))
			{
				Console.Write ("Please enter your choice!\n Enter \'s\' for string,\'i\' for integer and \'d\' for double:");
				str=Console.ReadLine();
			}
			switch (str) 
			{
				case "i":
			{   		Console.WriteLine ("Enter integer:");
						int intNum = int.Parse (Console.ReadLine());
						intNum++;
						Console.WriteLine ("The entered integer number is {0} and now it is modified to {1}", intNum - 1, intNum);
					};
					break;
				case "d":
					{
						Console.WriteLine ("Enter double:");
						double dNum = double.Parse (Console.ReadLine());
						dNum++;
						Console.WriteLine ("The entered double number is {0} and now it is modified to {1}", dNum - 1, dNum);
					};
					break;
				default:
					{
						Console.WriteLine ("Enter string:");
						string entStr = Console.ReadLine ();
						Console.WriteLine ("The entered string is {0} and now it ismodified to {1}", entStr, entStr + "*");
					};	break;
			}
		}
	}
}
