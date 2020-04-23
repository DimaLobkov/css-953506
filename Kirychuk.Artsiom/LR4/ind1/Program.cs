using System;
using System.Runtime.InteropServices;

namespace ind1
{
    class Program
    {
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int MessageBox(int hWnd, String text, String caption, uint type);
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool LockWorkStation();
        static void Main(string[] args)
        {
            Shape();
        }

        public static void Shape()
        {
            Console.Clear();
            Console.WriteLine("1.Имя студента");
            Console.WriteLine("2.Университет");
            Console.WriteLine("3.Специальность");
            Console.WriteLine("4.Выход");
            int menu;
            while (!int.TryParse(Console.ReadLine(), out menu))
            {
                Console.WriteLine("Введите снова");
            }
            if (menu == 1) MessageBox(0, "Киричук Артём", "Имя студента", 0);
            else if (menu == 2) MessageBox(0, "Белорусский государственный университет информатики и радиоэлектроники", "Университет", 1);
            else if (menu == 3) MessageBox(0, "Информатика и технологии программирования", "Специальность", 2);
            else { LockWorkStation(); Environment.Exit(0); }
            Next();
        }

        public static void Next()
        {
            Console.Clear();
            Console.WriteLine("1.Продолжить");
            Console.WriteLine("2.Выход");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Введите снова");
            }
            if (choice == 1) Shape();
            else { LockWorkStation(); Environment.Exit(0); } 
        }
    }
}
