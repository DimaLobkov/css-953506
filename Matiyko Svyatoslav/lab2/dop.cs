// С помощью класса DateTime вывести на консоль названия месяцев на француз-ском языке.
// По желанию обобщить на случай, когда язык задается с клавиатуры.

using System;
using System.Globalization;

namespace dop
{
    class Program
    {
        static void Main(string[] args)
        {
            static void output_months(string cultures)
            {
                CultureInfo culture = new CultureInfo(cultures);
                DateTime MyMonths = new DateTime();
                
                for (int i = 0; i < 12; i++)
                {
                    string month = MyMonths.ToString("M",culture);
                    Console.WriteLine(month);
                    MyMonths = MyMonths.AddMonths(1);
                }
                Console.ReadLine();
            }

            string[] cultures ={"en-GB","ru_RU","fr-FR"}; 

            do
            {
                Console.Clear();
                Console.WriteLine("выберите один из языков:\n1.english\n2.russian\n3.french\n4.выход\n");
                char choose;
                choose = Convert.ToChar(Console.ReadLine());
                               
                switch(choose)
                {
                    case '1':
                    {
                        output_months(cultures[0]);
                        break;
                    }
                    case '2':
                    {
                        output_months(cultures[1]);
                        break;
                    }
                    case '3':
                    {
                        output_months(cultures[2]);
                        break;
                    }
                    case '4':
                    {
                        break;
                    }
                }

                if(choose=='4')
                {
                    break;
                }
            } while (true);
        }
    }
}