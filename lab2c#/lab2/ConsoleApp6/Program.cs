using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = DateTime.Now.ToString("dd.MM.yyyy | HH:mm");
            string time2 = DateTime.Now.ToString("dd MMMM yyyy | hh:mm tt");

            Console.WriteLine(time);
            Console.WriteLine(time2);

            int Num1 = time.Count(x => x == '1') + time2.Count(x => x == '1');
            int Num2 = time.Count(x => x == '2') + time2.Count(x => x == '2'); 
            int Num3 = time.Count(x => x == '3') + time2.Count(x => x == '3');
            int Num4 = time.Count(x => x == '4') + time2.Count(x => x == '4');
            int Num5 = time.Count(x => x == '5') + time2.Count(x => x == '5');
            int Num6 = time.Count(x => x == '6') + time2.Count(x => x == '6');
            int Num7 = time.Count(x => x == '7') + time2.Count(x => x == '7');
            int Num8 = time.Count(x => x == '8') + time2.Count(x => x == '8');
            int Num9 = time.Count(x => x == '9') + time2.Count(x => x == '9');
            int Num0 = time.Count(x => x == '0') + time2.Count(x => x == '0');

            Console.WriteLine($"Кол-во едениц = {Num1}");
            Console.WriteLine($"Кол-во двоек = {Num2}");
            Console.WriteLine($"Кол-во троек = {Num3}");
            Console.WriteLine($"Кол-во четверок = {Num4}");
            Console.WriteLine($"Кол-во пятерок = {Num5}");
            Console.WriteLine($"Кол-во шестерок = {Num6}");
            Console.WriteLine($"Кол-во семерок = {Num7}");
            Console.WriteLine($"Кол-во восьмерок = {Num8}");
            Console.WriteLine($"Кол-во девяток = {Num9}");
            Console.WriteLine($"Кол-во нулей = {Num0}");
            
            Console.ReadLine();

        }
    }
}
