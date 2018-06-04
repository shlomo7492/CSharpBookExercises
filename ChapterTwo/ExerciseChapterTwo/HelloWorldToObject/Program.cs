using System;

namespace HelloWorldToObject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Създаваме програма, която печата \" Hello World!\" в тип  object като конкатенация на две променливи от тип string");
			string strHello = "Hello";
			string strWorld = "World!";
			object printToObject = strHello +" "+ strWorld;
			Console.WriteLine ("Стойността на конкатенацията е {0}", printToObject);
			string wholePhrase = printToObject.ToString ();
			Console.WriteLine ("Променливата wholePhrase има стойност: \" {0}\"", wholePhrase);
			wholePhrase = (string)printToObject;
			Console.WriteLine ("Променливата wholePhrase има стойност: \" {0}\" (това е втори вариант за type casting)", wholePhrase);

		}
	}
}
