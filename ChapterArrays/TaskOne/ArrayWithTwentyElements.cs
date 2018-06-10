using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    class ArrayWithTwentyElements
    {
        static void Main(string[] args)
        {
            int nIndex = 0;
            string str = null;
            bool testParse = false;
            while (testParse == false) // making sure the user is entering a number
            {
                Console.Write ("Enter number of elements of the array \'n\'=");
                str = Console.ReadLine();
                testParse = int.TryParse(str, out nIndex);
            }
            int[] intArray;
            intArray = new int[nIndex];
            for (int i = 0; i < nIndex; i++)
            {
                intArray[i] = i * 5;
                Console.Write("{0,4},", intArray[i]);
            }
            Console.Write("\n Press any key to exit...");
            Console.ReadKey();
        }
    }
}
