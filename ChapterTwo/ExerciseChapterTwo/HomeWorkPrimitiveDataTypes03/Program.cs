using System;

namespace HomeWorkPrimitiveDataTypes03
{
	class MainClass
	{
		public static void Main ()
		{

			Console.WriteLine ("Hello, this is my tird task! Operations with floating point numbers and precision of the result is 0.000001");
			Console.WriteLine ("Using decimal type");
			decimal decimalValueOne = 3.141592653589793238m; //that is tha most popular variation of pi
			decimal decimalValueTwo = 6.283185307179586476m; // that is another variation of pi
			Console.WriteLine ("Value One is {0} and Value Two is {1}", decimalValueOne,decimalValueTwo);
			decimal resultOfDecimalValues = decimalValueOne + decimalValueTwo;
			Console.WriteLine ("The sume of both decimal values is {0}", resultOfDecimalValues);
			resultOfDecimalValues = decimalValueOne * decimalValueTwo;
			Console.WriteLine ("The multiplication of both decimal values is {0}", resultOfDecimalValues);
			resultOfDecimalValues = decimalValueOne / decimalValueTwo;
			Console.WriteLine ("The division of both decimal values is {0}", resultOfDecimalValues);
			Console.WriteLine ();

			Console.WriteLine ("\n Using double type");
			double doubleValueOne = 3.141592653589793238; //that is tha most popular variation of pi
			double doubleValueTwo = 6.283185307179586476; // that is another variation of pi
			Console.WriteLine ("Value One is {0} and Value Two is {1}", doubleValueOne,doubleValueTwo);
			double resultOfDoubleValues = doubleValueOne + doubleValueTwo;
			Console.WriteLine ("The sume of both double values is {0}", resultOfDoubleValues);
			resultOfDoubleValues = doubleValueOne * doubleValueTwo;
			Console.WriteLine ("The multiplication of both double values is {0}", resultOfDoubleValues);
			resultOfDoubleValues = doubleValueOne / doubleValueTwo;
			Console.WriteLine ("The division of both double values is {0}", resultOfDoubleValues);
			Console.WriteLine ();

			Console.WriteLine ("\n Using float type");
			float floatValueOne = 3.141592653589793238f; //that is tha most popular variation of pi
			float floatValueTwo = 6.283185307179586476f; // that is another variation of pi
			Console.WriteLine ("Value One is {0} and Value Two is {1}", floatValueOne,floatValueTwo);
			float resultOfFloatValues = floatValueOne + floatValueTwo;
			Console.WriteLine ("The sume of both float values is {0}", resultOfFloatValues);
			resultOfFloatValues = floatValueOne * floatValueTwo;
			Console.WriteLine ("The multiplication of both float values is {0}", resultOfFloatValues);
			resultOfFloatValues = floatValueOne / floatValueTwo;
			Console.WriteLine ("The division of both float values is {0}", resultOfFloatValues);
			Console.WriteLine ();

			Console.WriteLine ("Operations Sum and multiplication work with double and decimal data type as well for this task");

		}
	}
}
