using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareEquation
{
    class SquareEquation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program finds the values of x in squre equation");
            string ctrStr=null;
            string[] index;
            index = new string[3]{"a","b","c"};
            float[] indexVal;
            indexVal = new float[3];
            bool testParse = false;
            for (int i = 0; i <= 2;i++ )
            {
                while (testParse == false)
                {
                    Console.WriteLine("Enter {0}", index[i]);
                    ctrStr = Console.ReadLine();
                    testParse = float.TryParse(ctrStr, out indexVal[i]);
                }
                testParse = false;
            }
            float dValue = indexVal[1] * indexVal[1] - 4 * indexVal[0] * indexVal[2];
            if (dValue > 0)
            {
                Console.WriteLine("There are two different values of x.\nThe first value of x is:{0,2:###0.00}\nThe second value of x is:{1,2:###0.00}", (-indexVal[1] + Math.Sqrt(dValue)) / (2 * indexVal[0]), (-indexVal[1] - Math.Sqrt(dValue)) / (2 * indexVal[0]));
            }
            else if (dValue == 0)
            {
                Console.WriteLine("There are two equal values of x.\nThe first value of x is {0,2:###0.00} and it is equal ot second value of x is {1,2:###0.00} too.", (-indexVal[1] + Math.Sqrt(dValue)) / (2 * indexVal[0]), (-indexVal[1] - Math.Sqrt(dValue)) / (2 * indexVal[0]));

            }
            else
            {
                Console.WriteLine("There are no real values for x.");
            }
            Console.ReadKey();
        }
    }
}
