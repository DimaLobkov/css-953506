using System;
using System.Runtime.InteropServices;

namespace ind1
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern int MessageBox(int hWnd, String text, String caption, uint type);

        public static void DT()
        {
            Console.WriteLine("1.Дата и время на данный момент(Беларусь)");
            Console.WriteLine("2.Дата и время(по Гринвичу)");
            Console.WriteLine("3.Только дата");
            Console.WriteLine("4.Только время(Беларусь)");
            Console.WriteLine("5.Только время(по Гринвичу)");
            Console.WriteLine("6.Ничего из вышеперечисленного");
            int choise;
            while (!int.TryParse(Console.ReadLine(), out choise))
            {
                Console.WriteLine("Некорректное значение, введите снова");
            }
            if (choise == 1)
            {
                DateTime now = DateTime.Now;
                string dataTime = now.ToString("dd.MM.yyyy HH:mm:ss	");
                MessageBox(0, dataTime, "Дата и время на данный момент(Беларусь): ", 0);
            }
            else if (choise == 2)
            {
                DateTime now = DateTime.UtcNow;
                string dataTime = now.ToString("dd.MM.yyyy HH:mm:ss	");
                MessageBox(0, dataTime, "Дата и время по Гринвичу: ", 0);
            }
            else if (choise == 3)
            {
                DateTime now = DateTime.Now;
                string dataTime = now.ToString("dd.MM.yyyy ");
                MessageBox(0, dataTime, "Сегодняшняя дата: ", 0);
            }
            else if (choise == 4)
            {
                DateTime now = DateTime.Now;
                string dataTime = now.ToString(" HH:mm:ss");
                MessageBox(0, dataTime, "Время сейчас(Беларусь)", 0);
            }
            else if (choise == 5)
            {
                DateTime now = DateTime.UtcNow;
                string dataTime = now.ToString("HH:mm:ss");
                MessageBox(0, dataTime, "Время сейчас(по Гринвичу)", 0);
            }
            else if(choise == 6)
            {
                Console.WriteLine("До свидания, если вам это понадобится, возвращайтесь!");
                Environment.Exit(-1);
            }
            Next();
        }

        public static void Next()
        {
            Console.Clear();
            Console.WriteLine("Хотите продолжить? ");
            string choice = Console.ReadLine();
            if (choice == "да" || choice == "yes")
            {
                DT();
            }
            else
            {
                Environment.Exit(-1);
                Console.WriteLine("До свидания!");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, хотите узнать дату или время?");
            string choise = Console.ReadLine();
            Console.Clear();
            if (choise == "да" || choise == "yes")
            {
                DT();
            }
            else
            {
                Console.WriteLine("До свидания!");
                Environment.Exit(-1);
            }
        }
    }
}