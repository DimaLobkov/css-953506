using System;
using System.Runtime.InteropServices;

namespace laba4task2
{
    class Program
    {
        [DllImport("C:\\Users\\Elena\\source\\repos\\MyLib\\Debug\\MyLib.dll")]
        public static extern double SquareRect(double Side1, double Side2);

        [DllImport("C:\\Users\\Elena\\source\\repos\\MyLib\\Debug\\MyLib.dll")]
        public static extern double SquareTr(double Side, double Height);

        static void Main(string[] args)
        {
            double Square = SquareRect(10.5, 6.5);
            double SquareTriangle = SquareTr(3.5, 10.0);

            Console.WriteLine($" Square of Triangle = {SquareTriangle}");
            Console.WriteLine($" Square of Rectangle = {Square}");
        }
    }
}