using System;

namespace IntegersTenAndFive
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int ten = 10;
			int five = 5;
			Console.WriteLine ("Hello this is five:{0} and this is ten:{1}", five,ten);
			ten = ten - five;
			five = five + ten;
			Console.WriteLine ("We have swiched the values and now this is five:{0} and this is ten:{1}", five,ten);

		}
	}
}
