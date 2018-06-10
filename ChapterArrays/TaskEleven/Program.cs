using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEleven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Sum to be checked");
            int sum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements of the array separated by space");
            string[] inputLine = Console.ReadLine().Split(' ');
            int[] numArr = new int[inputLine.Length];
            for (int i = 0; i <= inputLine.Length - 1; i++) 
            { 
                numArr[i]=int.Parse(inputLine[i]);
            }
            int startPosition = 0;
            int endPosition = 0;

            for (int i= 0; i<=numArr.Length-1;i++)
            {
                int tempSum=0;
                int j=i;
                while ((tempSum != sum)&&(j<numArr.Length))
                {
                    tempSum+=numArr[j];
                    j++;
                }
                if (tempSum==sum)
                {
                    startPosition = i;
                    endPosition = j - 1;
                }
            }
            for (int i = startPosition; i <= endPosition; i++)
            {
                Console.Write("{0} ", numArr[i]);
            }

        }
    }
}
