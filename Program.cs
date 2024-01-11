using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val = 1, blank, i, j;

            Console.WriteLine("====Enter the number of rows you wish to see in  pascal triangle======");
            int rows= int.Parse(Console.ReadLine());

          //nested for loops
            for (i = 0; i < rows; i++)
            {
                for (blank = 1; blank <= rows - i; blank++)
                    Console.Write(" ");
                for (j = 0; j <= i; j++)
                {

                    if (j == 0 || i == 0)
                        val = 1;
                    else
                        val = val * (i - j + 1) / j;
                    Console.Write(val + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
