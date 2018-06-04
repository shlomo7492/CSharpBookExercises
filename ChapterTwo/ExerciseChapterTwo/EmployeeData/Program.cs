using System;

namespace EmployeeData
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int minID = 27560000;
			int maxID = 27569999;
			Console.WriteLine ("Име:");
			string firstName = Console.ReadLine ();
			Console.WriteLine ("Фамилия:");
			string lastName = Console.ReadLine ();
            Console.WriteLine ("Възраст:");
			byte age = byte.Parse(Console.ReadLine ());
			Console.WriteLine ("Пол (м/ж):");
			object sexObject = Console.ReadLine ();
			int employeeID;
			do 
			{
				Console.WriteLine ("Номер на служителя(между {0} и {1}):", minID, maxID);
				employeeID = int.Parse(Console.ReadLine ());
			}while( employeeID <= minID || employeeID >= maxID);

			Console.WriteLine ("Данни на служителя - Име: {0},\nФамилия:{1} ,\nВъзраст: {2},\nПол: {3},\nСлужебен номер:{4}", firstName,lastName,age,sexObject,employeeID);

		}
	}
}
