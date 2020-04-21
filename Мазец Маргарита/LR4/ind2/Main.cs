using System;
using System.Runtime.InteropServices;

namespace TestDLL
{
    class Program
    {
        [DllImport("C:\\Users\\HP\\Documents\\Embarcadero\\Studio\\Projects\\MyDLL\\Win32\\Debug\\Project8.dll")]
        public static extern double boddyMassIndex(double weight, double heigth);

        static void Main(string[] args)
        {
            Console.WriteLine("Введите рост:");
            double heigth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вес:");
            double weigth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(boddyMassIndex(weigth, heigth));
        }
    }
}