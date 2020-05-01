using System;
using System.Runtime.InteropServices;   // подключаем атрибут DllImport 

namespace ConsoleApplication1
{
    class Program
    {
        // Импортируем библиотку user32.dll (содержит WinAPI функцию MessageBox) 
        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, int options); // объявляем метод на C# 

        static void Main()
        {
            int round, urScore = 0, compScore = 0;

            Random rnd = new Random();

            Console.Write("\tRock-paper-scissors\nYour task is to beat the computer!\n\nEnter the number of rounds: ");
            while (!int.TryParse(Console.ReadLine(), out round))
            {
                Console.WriteLine("\n\tIncorrect input. Try again");
            }

            Console.WriteLine("\n\tGame on!!!");
            for (int counter = 0; counter < round; counter++)
            {
                int urSelect, compSelect;

                Console.WriteLine("\nSelect\n1) Rock\n2) Paper\n3) Scissors\n4) To surrender");
                while (!int.TryParse(Console.ReadLine(), out urSelect))
                {
                    Console.WriteLine("\n\tIncorrect input. Try again");
                }
                
                compSelect = rnd.Next(1, 4);
                if (urSelect == 4)
                {
                    Console.WriteLine("\nAutomatic defeat");
                    return;
                }

                else if ((urSelect > compSelect) || (urSelect == 1 && compSelect == 3))
                {
                    urScore++;
                    MessageBox(IntPtr.Zero, "YOU WON!", $"the results of the round {counter + 1}", 0);
                }

                else if(urSelect == compSelect)
                {
                    urScore++;
                    compScore++;
                    MessageBox(IntPtr.Zero, "Tie", $"the results of the round {counter + 1}", 0);
                }

                else
                {
                    compScore++;
                    MessageBox(IntPtr.Zero, "You lost...", $"the results of the round {counter + 1}", 0);
                }

                Console.Clear();
                Console.WriteLine($"Your score: {urScore}\nComputer score: {compScore}");
            }

            if(urScore > compScore)
            {
                MessageBox(IntPtr.Zero, "YOU ARE WINNER!", $"score {urScore}:{compScore}", 0);
            }

            else if (urScore < compScore)
            {
                MessageBox(IntPtr.Zero, "COMPUTER ARE WINNER!", $"score {urScore}:{compScore}", 0);
            }

            else
            {
                MessageBox(IntPtr.Zero, "TIE", $"score {urScore}:{compScore}", 0);
            }
        }
    }
}