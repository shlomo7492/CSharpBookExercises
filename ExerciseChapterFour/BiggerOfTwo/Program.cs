using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerOfTwo
{
    class BiggerOfTwoInts
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers:");
            Console.Write("First number:");
            float firstNum = float.Parse(Console.ReadLine());
            Console.Write("Second number:");
            float secondNum = float.Parse(Console.ReadLine());
            Console.WriteLine("The greater number of both is: {0}", Math.Max(firstNum, secondNum));
            Console.ReadLine();
        }
    }
}
