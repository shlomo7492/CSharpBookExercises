using System;

namespace BonusPointsMultiplicator
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int basePoints = 0;
			int bonus = 0;
			string str = null;
			bool parseTest = false;
			while (parseTest==false) 
			{
				Console.WriteLine ("Please enter your points (1-9):");
				str = Console.ReadLine ();
				parseTest = int.TryParse (str, out basePoints);
			}
			switch (basePoints) 
			{
				case 1:
				case 2:
				case 3:
					bonus=basePoints*10;
					break;
				case 4:
				case 5:
				case 6:
					bonus=basePoints*100;
					break;
				case 7:
				case 8:
				case 9:
					bonus=basePoints*1000;
					break;
				default:
					Console.WriteLine ("The amount of the points is incorect.");
					break;
			}
			if ((bonus > 0) || (bonus < 10)) 
			{
				Console.WriteLine ("The bonus points reached are: {0}", bonus);
			}
		}
	}
}
