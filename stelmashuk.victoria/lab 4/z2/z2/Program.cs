using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace TestDLL
{
    class Program
    {
        [DllImport("Dll.lib", CallingConvention = CallingConvention.Cdecl)]
        public static extern double IMT(double weight, double heigth);

        static void Main(string[] args)
        {
            Console.WriteLine("Введите рост:");
            double heigth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вес:");
            double weigth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(IMT(weigth, heigth));
        }
    }
}