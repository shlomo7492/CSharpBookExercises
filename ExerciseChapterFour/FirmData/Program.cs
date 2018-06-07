using System;

namespace FirmData
{
	class CompanyInfo
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Please enter the company data!");
			Console.Write ("Company name:");
			string compName = Console.ReadLine ();
			Console.Write ("Company address:");
			string compAddr = Console.ReadLine ();
			Console.Write ("Company phone number:");
			string compPhone = Console.ReadLine ();
			Console.Write ("Company fax number:");
			string compFax = Console.ReadLine ();
			Console.Write ("Company website:");
			string compWeb = Console.ReadLine ();
			Console.WriteLine ("Company manager:");
			Console.Write ("Name:");
			string managerName = Console.ReadLine ();
			Console.Write ("Last name:");
			string managerLastName = Console.ReadLine ();
			Console.Write ("Manager phone number:");
			string managerPhone = Console.ReadLine ();

			Console.WriteLine ("The " + compName + " resides at " + compAddr + ". Manager of " + compName + " is " + managerName + " "+managerLastName + ". " +
				"Please call us at: " + compPhone + " or send us a fax at: " + compFax + ". You can visit our website: " + compWeb + " and check for our latest products. " +
				"You can reach " + managerName + " " + managerLastName + " at: " + managerPhone);
			                  
		}
	}
}
