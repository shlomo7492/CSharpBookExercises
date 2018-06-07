using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxOfFiveNum
{
    class MaxOfFive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will calculate the sum of five number values \n entered from the keyboard.");
            string ctrString;
            float numVal = 0f;
            float numMax = 0f;
            bool parseTrue = false;
            for (int i = 1; i <= 5; i++)
            {
                while (parseTrue == false)
                {
                    Console.WriteLine("Enter the number value {0}", i);
                    ctrString = Console.ReadLine();
                    parseTrue = float.TryParse(ctrString, out numVal);
                }
                if ((parseTrue == true)&&(numMax <= numVal))
                {
                    numMax=numVal;
                    parseTrue = false;
                }
                parseTrue = false;
            }
            Console.WriteLine("The maximum value of all five numbers is {0,-7:###0.00}", numMax);
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }

    }
}
