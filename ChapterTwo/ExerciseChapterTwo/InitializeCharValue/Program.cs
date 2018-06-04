using System;

namespace InitializeCharValue
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Инициализиране на променлива от тип \" char \" зададена с Unicode 72");
			char charValue = '\u0048';
			Console.WriteLine ("Символът с код 72 e {0}", charValue);
 		}
	}
}
