using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3and5
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 0;
            //int z = 3;
            //for (int i = 1; x < 1000; i++)
            //{
            //    x = z * i;
            //    Console.WriteLine(x);
            //}
            //int y = 5;
            //for (int i = 5; i < 1000; y++)
            //{
            //    int w = i * y;
            //}

            //Console.WriteLine();


            int sum = 0;

            for (int i = 0; i <= 1000; i++)
            {
                if ((i%3 == 0) || (i%5 == 0))
                {
                    sum = sum + i;
                    Console.WriteLine(sum);
                }
            }

        }
    }
}
