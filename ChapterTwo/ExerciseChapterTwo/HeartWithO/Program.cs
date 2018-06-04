using System;

namespace HeartWithO
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			char symbolO = 'o';
			Console.WriteLine ("we gona print a heart using this symbol - \'o\'");
			Console.WriteLine ("\t    {0}          {0}", symbolO);
			Console.WriteLine ("        {0}       {0}  {0}       {0}", symbolO);
			Console.WriteLine ("       {0}         {0}{0}         {0}", symbolO);
			Console.WriteLine ("       {0}         {0}          {0}", symbolO);
			Console.WriteLine ("        {0}                  {0}", symbolO);
			Console.WriteLine ("         {0}                {0}", symbolO);
			Console.WriteLine ("          {0}              {0}", symbolO);
			Console.WriteLine ("            {0}          {0}", symbolO);
			Console.WriteLine ("              {0}      {0}", symbolO);
			Console.WriteLine ("                {0}  {0}", symbolO);
			Console.WriteLine ("                 {0}{0}", symbolO);
		}
	}
}
