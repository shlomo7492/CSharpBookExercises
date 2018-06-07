using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFistHundredFibonachiNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int nVal = 101;
            bool parseTemp = false;
            string ctrStr = null;
            while (parseTemp == false)
            {
                Console.WriteLine("Please enter value for \'n\':");
                ctrStr = Console.ReadLine();
                parseTemp = Int32.TryParse(ctrStr, out nVal);
            }
            int[] fibNum;
            fibNum = new int[nVal];
            
            for (int i = 0; i <= (nVal - 1); i++)
            {
                if (i==0)
                {
                    fibNum[i]=0;
                }
                else if (i==1)
                {
                    fibNum[i]=1;
                }
                else
                {
                    fibNum[i] = fibNum[i - 1] + fibNum[i - 2];
                }
                Console.WriteLine("The value of Fibonachì number with index {0} is: {1}",i,fibNum[i]);
            }
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
