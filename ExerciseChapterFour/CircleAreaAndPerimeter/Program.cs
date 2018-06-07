using System;

namespace CircleAreaAndPerimeter
{
	class EnterRAndCalculate
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("If you enter the radius of a circle this program will calculate the Perimeter and the Area of it.");
			Console.Write ("Please enter the radius (r):");
			double r = double.Parse (Console.ReadLine ());
			double pi = 3.14159265358979;
			double perimeter = 2 * pi * r;
			double area = pi * r * r;

			Console.WriteLine ("The perimeter of the circle is {0:###.##} and the area of the circle is {1:###.##}", perimeter, area);
		}
	}
}
