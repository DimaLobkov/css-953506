using System;
using System.Runtime.InteropServices;

namespace _4._2
{
    class ForDLL
    {
        [DllImport("C:\\Users\\ZenBook\\Desktop\\LabWorks\\ISP\\LW-4\\Dll1\\Debug\\Dll1\\Dll1.dll")]
        public static extern float VolumePrlpd(float a, float b, float c);

        static void Main(string[] args)
        {
            float a, b, c;

            Console.WriteLine("\t\tHello!\n\nYou are welcomed by the program for calculating the volume of a parallelepiped.");
            Console.Write("All you have to do is enter the source data.\n\ta = ");
            while (!float.TryParse(Console.ReadLine(), out a))
            {
                Console.Write("\n\tIncorrect input. Try again\n\ta = ");
            }

            Console.Write("\tb = ");
            while (!float.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("\n\tIncorrect input. Try again\n\tb = ");
            }

            Console.Write("\tc = ");
            while (!float.TryParse(Console.ReadLine(), out c))
            {
                Console.Write("\n\tIncorrect input. Try again\n\tc = ");
            }

            Console.WriteLine(VolumePrlpd(a, b, c));
        }
    }
}