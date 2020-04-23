using System;
using System.Runtime.InteropServices;

namespace ind2
{
    class Program
    {
        [DllImport("C:\\Users\\User\\Documents\\Embarcadero\\Studio\\Projects\\dll\\Win32\\Debug\\Project1.dll")]
        public static extern double Area(double side);
        [DllImport("C:\\Users\\User\\Documents\\Embarcadero\\Studio\\Projects\\dll\\Win32\\Debug\\Project1.dll")]
        public static extern double Angle(double amside);     
        static void Main(string[] args)
        {

             Console.WriteLine("Введите длину стороны правильного треугольника");
             double side = Convert.ToInt64(Console.ReadLine());
             Console.WriteLine("площадь=",+Area(side));
             Console.WriteLine("Введите кол-во сторон правильного n-угольника");
             double amside = Convert.ToInt64(Console.ReadLine());
             Console.WriteLine("угол=", +Angle(amside));
        }
    }
}
