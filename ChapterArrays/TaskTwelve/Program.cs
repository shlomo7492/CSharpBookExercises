using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwelve
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrixA = new int[size, size];
            int[,] matrixB = new int[size, size];
            int[,] matrixC = new int[size, size];
            int[,] matrixD = new int[size, size];



            for (int i = 0; i <= size - 1; i++)
            {
                for (int j = 0; j <= size-1; j++)
                {
                   if ((j == 0) && (i == 0))
                   {
                       matrixA[i, j] = 1;
                   }
                   else if (j == 0 && i != 0) 
                   {
                       matrixA[i, j] = matrixA[i-1, j] + 1;
                   }
                   else
                   {
                       matrixA[i, j] = matrixA[i, j - 1] + size;
                   }
                   Console.Write("{0} ", matrixA[i, j]);
                }
                Console.WriteLine();
           }
           for (int j = 0; j <= size - 1; j++)
            {
                
                for (int i = 0; i <= size - 1; i++)
                { 
                    if ((i == 0) && (j == 0))
                    {
                        matrixB[i, j] = 1;
                    }
                     else if (i != 0 && j == 0)
                     {
                         matrixB[i, j] = matrixB[i-1, j] + 1;
                     }
                    else if (j!=0)
                    {
                        if (j % 2 == 0)
                        {
                            if (i == 0)
                            {
                                matrixB[i, j] = matrixB[size - 1, j - 1] + size;
                            }
                            else
                            {
                                matrixB[i, j] = matrixB[i - 1, j] + 1;
                            }
                        }
                        if (j % 2 != 0)
                        {
                            if (i == 0)
                            {
                                matrixB[i, j] = matrixB[size - 1, j - 1] + size;
                            }
                            else
                            {
                                matrixB[i, j] = matrixB[i - 1, j] - 1;
                            }
                        }
                    }
                }
            }
            for (int i=0;i<size;i++)
            {
                for (int j=0;j<size;j++)
                {
                    Console.Write("{0} ", matrixB[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
