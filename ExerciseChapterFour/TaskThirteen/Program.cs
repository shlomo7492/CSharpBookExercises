using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskThirteen
{
    class Program //Sum 1+1/2+1/3+1/4... etc.
    {
        static void Main(string[] args)
        {
            float i = 1f;
            float sumVal = 0f;
            float currentVal=1f;
            float tempSum = 1f;
               
            
            while ((tempSum > 0.001) == true)
            {
                tempSum = sumVal;
                currentVal = 1 / i;
                sumVal = sumVal + currentVal;
                tempSum = sumVal - tempSum;
                //if (tempSum=>0.001)
                i++;
            }
            Console.WriteLine("We made {0} loops, \nand the cuurent sum is {1,10:f3}", i-1, sumVal);
            
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
