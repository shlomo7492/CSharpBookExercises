using System;

namespace PrintMatrix
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Print Matrix");
			int n = 0;
			string str = null;
			bool parseTest = false;
			while (parseTest==false)
			{
				Console.WriteLine ("Please enter value for \'n\'.");
				str = Console.ReadLine ();
				parseTest = Int32.TryParse (str, out n);
			}
			for (int i=1; i<=n; i++)
			{
				for (int border=1; border<=n; border++)
				{  
					if (border == n)
					{
						Console.WriteLine ("___");
					} 
					else if (border == 1) 
					{
						Console.Write (" ___");
					} 
					else 
					{
						Console.Write ("___");
					}
				}
				for (int column=i; column<=n-1+i; column++) 
				{
					if (column == i) 
					{
						Console.Write ("|{0,2}|", column);
					} 
					else if (column != (n-1+i)) 
					{
						Console.Write ("{0,2}|", column);
					} 
					else 
					{
						Console.WriteLine ("{0,2}|", column);
					}
				}
				if (i == n) 
				{
					for (int borderBott=1; borderBott<=n; borderBott++)
					{
						if (borderBott == n) 
						{
							Console.WriteLine ("---");
						} 
						else if (borderBott==1)
						{
							Console.Write (" ---");
						}
						else
						{
							Console.Write ("---");
						}
					}
				}
			}

		}
	}
}
