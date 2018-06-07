using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveNumSum
{
    class FiveSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will calculate the sum of five number values \n entered from the keyboard.");
            string ctrString;
            float numVal=0f;
            float numSum=0f;
            bool parseTrue = false;
            for (int i = 1; i <= 5; i++)
            {
                while (parseTrue == false)
                {
                    Console.WriteLine("Enter the number value {0}", i);
                    ctrString = Console.ReadLine();
                    parseTrue = float.TryParse(ctrString, out numVal);
                }
                if (parseTrue == true)
                {
                    numSum = numSum + numVal;
                    parseTrue = false;
                }
            }
            Console.WriteLine("The sum of the entered five values is {0,-7:####.##}", numSum);
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
        
    }
}
