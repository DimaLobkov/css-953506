using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Lab4
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern int MessageBox(int hWnd, String text, String caption, uint type);

        static void Main(string[] args)
        {
            bool[] check = new bool[5] { false, false, false, false, false };
            bool[] prize = new bool[5] { false, false, false, false, false };
            int[] index = new int[5] { 1, 2, 3, 4, 5 };
            uint choice;
            var rand = new Random();
            int r = rand.Next(5);
            prize[r] = true;
            Console.WriteLine("Добро пожаловать в игру-угадайку!");
            while (true)
            {
                Console.WriteLine("В какой ячейке спрятан приз?");
                for (int i = 0; i < 5; i++)
                {
                    if (check[i])
                    {
                        Console.WriteLine($"{index[i]}.Пусто");
                    }
                    else
                    {
                        Console.WriteLine($"{index[i]}.???");
                    }
                }
                while(!UInt32.TryParse(Console.ReadLine(), out choice) || choice > 5 || choice == 0)
                {
                    Console.WriteLine("Введите цифру от 1 до 5");
                }
                if(prize[choice - 1])
                {
                    MessageBox(0, "ПРИЗ!!!", "Угадайка", 0);
                    break;
                }
                else
                {
                    MessageBox(0, "Неудача! Попробуйте еще раз!", "Угадайка", 0);
                    check[choice - 1] = true;
                }
                Console.Clear();
            }
        }
    }
}
