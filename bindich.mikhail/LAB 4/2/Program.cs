using System;
using System.Runtime.InteropServices;
using System.Text;

namespace _4._2
{
    class Program
    {
        [DllImport("DLLI02-3.dll")]
        private static extern double rec(int[] b, int i, int last); 
        // Функция rec получает на входе массив с рандомными числами, размерность массива, рекурсивно вычисляет произведение множитилей
        // по формуле Bi * Bi + cos(Bi)
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n - ");
            int n = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                b[i] = random.Next(1000);
                Console.WriteLine(b[i]);
            }

            Console.WriteLine(rec(b, 0, n));
        }
    }
}
