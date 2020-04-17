using System;
using System.Runtime.InteropServices;

namespace z2
{
    class Program
    {
        [DllImport("D:\\Nik\\Laby\\Isp_2\\LR4\\z2\\DLL.dll")]
        public static extern double Sum(double a, double b);

        [DllImport("D:\\Nik\\Laby\\Isp_2\\LR4\\z2\\DLL.dll")]
        public static extern double Sub(double a, double b);

        [DllImport("D:\\Nik\\Laby\\Isp_2\\LR4\\z2\\DLL.dll")]
        public static extern double Mult(double a, double b);

        [DllImport("D:\\Nik\\Laby\\Isp_2\\LR4\\z2\\DLL.dll")]
        public static extern double Div(double a, double b);

        [DllImport("D:\\Nik\\Laby\\Isp_2\\LR4\\z2\\DLL.dll")]
        public static extern int Mod(int a, int b);

        static void Menu()
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1)Сложить два числа");
            Console.WriteLine("2)Вычесть одно чилсо из другого");
            Console.WriteLine("3)Уножить одно число на другое");
            Console.WriteLine("4)Разделить одно число на другое");
            Console.WriteLine("5)Разделить одно число на другое по модулю");
            Console.WriteLine("6)Выход");

        }
        static void Main(string[] args)
        {
            int choice = 0;
            double a, b;
            int c, d;
            do
            {
                Menu();
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (choice) 
                {
                    case 1:                     
                        Console.WriteLine("Введите первое число");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Сумма равна {Sum(a, b)}"); 
                        break;
                    case 2:
                       
                        Console.WriteLine("Введите первое число");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Разность равна {Sub(a, b)}");
                        break;
                    case 3:
                    
                        Console.WriteLine("Введите первое число");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Произведение равно {Mult(a, b)}");
                        break;
                    case 4:
                     
                        Console.WriteLine("Введите первое число");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Частное равно {Div(a, b)}");
                        break;
                    case 5:
                   
                        Console.WriteLine("Введите первое число");
                        c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Частное по модулю {d} равно {Mod(c, d)}");
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Такого варианта нет, введите еще раз");
                        break;
                }
            } while (choice != 6);
        }
    }
}
