using System;

namespace HomeWorkPrimitiveDataTypes02
{
	class MainClass
	{
		public static void Main ()
		{
			Console.WriteLine ("Hello, this is my second task, it is a little experiment with variables ...");

			float floatValue = 12.345f;

			Console.WriteLine ("floatValue = {0}",floatValue);

			floatValue = 8923.1234857f;
			Console.WriteLine ("floatValue = {0}",floatValue);

			double doubleValue = 12.345;

			Console.WriteLine ("doubleValue = {0}",doubleValue);

			doubleValue = 8923.1234857;
			Console.WriteLine ("doubleValue = {0}",doubleValue);

			doubleValue = 34.567839023;
			Console.WriteLine ("doubleValue = {0}",doubleValue);

			doubleValue = 3456.091124875956542151256683467;
			Console.WriteLine ("doubleValue = {0}",doubleValue);

			decimal decimalValue = 3456.091124875956542151256683467m;
			Console.WriteLine ("decimalValue = {0}",decimalValue);
		}
	}
}
