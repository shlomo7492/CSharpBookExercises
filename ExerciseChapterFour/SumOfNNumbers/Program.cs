using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will calculate the sum of \'n\' numeric values.");
            int nVal = 0;
            string ctrStr = null;
            bool parseStr = false;
            while (parseStr == false)
            {
                Console.WriteLine("Enter \'n\':");
                ctrStr = Console.ReadLine();
                parseStr = Int32.TryParse(ctrStr, out nVal);
            }
            parseStr = false;
            float numSum = 0f;
            float numTemp = 0f;
            for (int i = 1; i <= nVal; i++)
            {
                while (parseStr == false)
                {
                    Console.WriteLine("Enter value \'{0}\':",i);
                    ctrStr = Console.ReadLine();
                    parseStr = float.TryParse(ctrStr, out numTemp);
                }
                numSum = numSum + numTemp;
                parseStr = false;
            }
            Console.WriteLine("The sum of the {0} numeric values is {1,10:###0.##}", nVal, numSum);
            Console.ReadKey();
        }
    }
}
