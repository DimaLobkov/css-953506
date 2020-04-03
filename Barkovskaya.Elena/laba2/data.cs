using System;

namespace labr2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            int zero = 0, one = 0, two = 0, three = 0, four = 0, five = 0, six = 0, seven = 0, eight = 0, nine = 0;
            Console.WriteLine("Первый формат: {0:f}", now);
            for (int i = 0; i < now.ToString("f").Length; i++)
            {
                switch (now.ToString("f")[i])
                {
                    case '0': zero++; break;
                    case '1': one++; break;
                    case '2': two++; break;
                    case '3': three++; break;
                    case '4': four++; break;
                    case '5': five++; break;
                    case '6': six++; break;
                    case '7': seven++; break;
                    case '8': eight++; break;
                    case '9': nine++; break;
                }
            }
            Console.WriteLine("Наименование цифры\tЕё количество\n\t0\t\t\t{0}\n\t1\t\t\t{1}\n\t2\t\t\t{2}\n\t3\t\t\t{3}\n\t4\t\t\t{4}\n\t5\t\t\t{5}\n\t6\t\t\t{6}\n\t7\t\t\t{7}\n\t8\t\t\t{8}\n\t9\t\t\t{9}\n\n\n", zero, one, two, three, four, five, six, seven, eight, nine);
            zero = 0; one = 0; two = 0; three = 0; four = 0; five = 0; six = 0; seven = 0; eight = 0; nine = 0;
            Console.WriteLine("\nВторой формат: " + now.ToString("G"));
            for (int i = 0; i < now.ToString("G").Length; i++)
            {
                switch (now.ToString("G")[i])
                {
                    case '0': zero++; break;
                    case '1': one++; break;
                    case '2': two++; break;
                    case '3': three++; break;
                    case '4': four++; break;
                    case '5': five++; break;
                    case '6': six++; break;
                    case '7': seven++; break;
                    case '8': eight++; break;
                    case '9': nine++; break;
                }
            }
            Console.WriteLine("Наименование цифры\tЕё количество\n\t0\t\t\t{0}\n\t1\t\t\t{1}\n\t2\t\t\t{2}\n\t3\t\t\t{3}\n\t4\t\t\t{4}\n\t5\t\t\t{5}\n\t6\t\t\t{6}\n\t7\t\t\t{7}\n\t8\t\t\t{8}\n\t9\t\t\t{9}", zero, one, two, three, four, five, six, seven, eight, nine);
        }
    }
}
