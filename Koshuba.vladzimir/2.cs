using System;
using System.Numerics;

namespace _2_stepen_
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong a, b, n = 0;
            while (true)
            {
                Console.WriteLine("must a < b");
                Console.Write("a = ");
                a = Convert.ToUInt64(Console.ReadLine());
                Console.Write("b = ");
                b = Convert.ToUInt64(Console.ReadLine());
                if (a >= b)
                {
                    Console.Clear();
                    Console.WriteLine("ERROR");
                }
                else break;
            }

            BigInteger c = 1;
            for (c = a; c <= b; c++)
            {
                BigInteger d = c;
                while (d % 2 == 0)
                {
                    d /= 2;
                    n++;
                }
            }
            Console.WriteLine($"\nstepen' of 2 {n}");
            Console.WriteLine("\n\ncontinue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
