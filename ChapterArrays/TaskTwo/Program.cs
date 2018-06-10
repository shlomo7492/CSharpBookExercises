using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int nIndex = 0;
            int kIndex = 0;
            string str = null;
            bool testParse = false;
            while (testParse == false)
            {
                Console.Write("Enter elements number for the first array:");
                str = Console.ReadLine();
                testParse = int.TryParse(str, out nIndex);
            }
            testParse = false;
            while (testParse == false)
            {
                Console.Write("Enter elements number for the second array:");
                str = Console.ReadLine();
                testParse = int.TryParse(str, out kIndex);
            }
            testParse = false;
            int[] firstArray, secondArray;
            firstArray = new int[nIndex];
            secondArray = new int[kIndex];
            if (nIndex != kIndex)
            {
                Console.WriteLine("The two arrays are not equal.");
            }
            else
            {
                for (int i = 0; i < nIndex; i++) 
                {
                    while (testParse == false)
                    {
                        Console.Write("Enter elements of the first array:");
                        str = Console.ReadLine();
                        testParse = int.TryParse(str, out firstArray[i]);
                    }
                    testParse = false;
                }
                for (int i = 0; i < kIndex; i++)
                {
                    while (testParse == false)
                    {
                        Console.Write("Enter elements of the second array:");
                        str = Console.ReadLine();
                        testParse = int.TryParse(str, out secondArray[i]);
                    }
                    testParse = false;
                } 
                bool isEqual =true;
                for (int i = 0; i < nIndex;i++ ) 
                {
                    if (firstArray[i]!=secondArray[i])
                    {
                        isEqual = false;
                        break;
                    } 
                }
                if (isEqual == true)
                {
                    Console.WriteLine("The two arrays are equal.");
                }
                else
                {
                     Console.WriteLine("The two arrays are not equal.");
                }
            }
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
