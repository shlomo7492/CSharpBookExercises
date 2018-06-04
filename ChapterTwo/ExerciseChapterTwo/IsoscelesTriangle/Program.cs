using System;

namespace IsoscelesTriangle
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			char symbolCopyRight = '\u00A9';
			Console.WriteLine ("     {0}", symbolCopyRight);
			Console.WriteLine ("    {0} {0}", symbolCopyRight);
			Console.WriteLine ("   {0}   {0}", symbolCopyRight);
			Console.WriteLine ("  {0}     {0}", symbolCopyRight);
			Console.WriteLine (" {0}       {0}", symbolCopyRight);
			Console.WriteLine ("{0}{0}{0}{0}{0}{0}{0}{0}{0}{0}{0}", symbolCopyRight);
		}
	}
}
