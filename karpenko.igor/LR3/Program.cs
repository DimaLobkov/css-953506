using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{    
    class Program
    {
        static void Main(string[] args)
        {
            int begin = 0;
            char ch;
            Console.WriteLine("Сколько патронов вы отели бы иметь на старте?");
            begin = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Gun pist = new Gun(begin);
            pist.Score = 0;
            do
            {
                pist.Info();
                Console.WriteLine($"Набранные вами очки: {pist.Score}");
                pist.Menu();
                Console.WriteLine();
                Console.WriteLine("p - Выход со стрельбища");
                ch = Console.ReadKey().KeyChar;
                Console.Clear();
                switch (ch) {
                    case 'f':
                        pist.Zaryad();
                        break;
                    case 'r':
                        pist.Remont();
                        break;
                    case 't':
                        pist.Fuse();
                        break;
                    case 'g':
                        pist.Perezaryad();
                        break;
                    case 'h':
                        pist.Pricel();
                        break;
                    case 'y':
                        pist.Shot();
                        break;
                    case 'j':
                        pist.Charac();
                        break;
                    case 'k':
                        pist.Razbor();
                        break;
                    case 'p':
                        return;                  

                    default:
                        Console.WriteLine("Такого действия нет(Нажмите любую клавишу для продолжения)");
                        Console.ReadKey();
                        break;
                }

            } while (true);
        }
    }
}
