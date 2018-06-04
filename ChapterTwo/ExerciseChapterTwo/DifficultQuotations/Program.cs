using System;

namespace DifficultQuotations
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string stringQuoted = "The \"use\" of quotations causes difficulties.";
			string stringNotQuoted = "The use of quotations causes difficulties.";

			Console.WriteLine ("stringQuoted is: {0} \nstringNotQuoted is: {1}", stringQuoted, stringNotQuoted);
		}
	}
}
