using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAllNumInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int nVal=0;
            bool parseTemp=false;
            string ctrStr;
            while (parseTemp == false)
            {
                Console.WriteLine("Please enter value for \'n\':");
                ctrStr = Console.ReadLine();
                parseTemp = Int32.TryParse(ctrStr, out nVal);
            }
            parseTemp = false;
            for (int i = 1; i <= nVal; i++)
            {
                Console.WriteLine("{0}", i);
            }
            Console.ReadKey();
        }
    }
}
