using System;

namespace GenderValidation
{
	class MainClass
	{
		public static void Main ()
		{
			Console.WriteLine ("Моля въведете вашият пол (мъж/жена):");
			string yourSex = Console.ReadLine ();
			bool isMale = (yourSex == "мъж");
			if (isMale)
			{ Console.WriteLine ("Чудесно! Вие сте мъж на място");
			}
			else
			{
				Console.WriteLine ("Прекрасно!Разбирам...");
			}
		}
	}
}
