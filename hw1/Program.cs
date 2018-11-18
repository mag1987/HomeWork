using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] a = RandomArray(5,5,23);
            int[,] b = RandomArray(5, 5, 34);

            PrintArray(a);
            PrintArray(b);

        }
        static void SumOfTwo()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);
        }
        static void BitOfNumber()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int i = Convert.ToInt32(Console.ReadLine());
            int iBit = 1 << i;

            Console.WriteLine((iBit & n) == 0 ? "0" : "1");
        }
        static void ZeroBiggestBit()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int i = (int)Math.Truncate(Math.Log(n, 2));
            n = n & ~(1 << i);
            Console.WriteLine(n);
        }
        static void PrintArray(int[,] a)
        {
            StringBuilder sBuild = new StringBuilder();
            for (int i=0; i<a.GetLength(0); i++)
            {
                for (int j =0; j<a.GetLength(1); j++)
                {
                    sBuild.Append(String.Format("{0,3:d}", a[i,j]));
                }
                Console.WriteLine(sBuild.ToString());
                sBuild.Clear();
            }
        }
        static int[,] RandomArray(int row, int column, int seed)
        {
            int[,] matrix = new int[row, column];
            Random r = new Random(seed);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = r.Next(0, 99);
                }
            }
            return matrix;
        }
    }
}
