using System;

namespace IntVariableInitInHexadecimal
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Инициализиране на целочислена променлива с 100 в шестнайсетична бр. система. \n");
			int hexInteger = 0x100;
			Console.WriteLine ("Стойността на променливата в десетична бр. система е {0}", hexInteger);
		}
	}
}
