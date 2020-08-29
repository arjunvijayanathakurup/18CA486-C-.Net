using System;
using System.Diagnostics.CodeAnalysis;

namespace Matric_Math_Operations_A_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a two-dimensional array which represents two matrices, find the sum, difference and product of these two matrices.
            int[,] a = new int[2, 2] { { 3, 5 }, { 7, 93 } };
            int[,] b = new int[2, 2] { { 84, 63 }, { 83, 94 } };
            int[,] sum = new int[2, 2];
            int[,] sub = new int[2, 2];
            int[,] mul = new int[2, 2];

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    mul[i, j] = 0;
                    sum[i, j] = a[i, j] + b[i, j];
                    sub[i, j] = a[i, j] - b[i, j];
                    for(int k = 0; k < 2; k++)
                    {
                        mul[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            Console.WriteLine("Matrix A: ");
            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Matrix B: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Sum is: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(sum[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Difference is: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(sub[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Product is: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(mul[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
