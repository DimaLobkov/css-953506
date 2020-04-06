using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Program
    {
        public class Complex
        {
            public Complex(double real, double imaginary)
            {
            }
        }
        static void Main()
        {
            string str;

            Console.WriteLine("Enter coefficients");
            str = Console.ReadLine();

            string[] coefs = str.Split(' '); //Разложение строки на массив строк
            double[] numb = new double[4];

            for (int i = 0; i < coefs.Length; i++)
            {
                numb[i] = Convert.ToDouble(coefs[i]);  //Перевод из строки в инт

            }

            double A = numb[0];
            double B = numb[1];
            double C = numb[2];
            double D = numb[3];

            Console.WriteLine($"Your equation {A}x^3 + {B}x^2 + {C}x + {D} = 0 ");
            //-----------------------------------------------------------------------------------------------------------------------------------------
            double dis0 = B * B - 3 * A * C;
            double dis1 = 2 * Math.Pow(B, 3) - 9 * A * B * C + 27 * A * A * D;
            double dis = (dis1 * dis1 - 4 * Math.Pow(dis0, 3)) / (27 * A);
            double CO = Math.Pow((Math.Sqrt(dis1 * dis1 - 4 * Math.Pow(dis0, 3)) + dis1) / 2, 1 / 3);
            double u = 1 - Math.Sqrt(3);
            string u1 = u + "+" + "i";

            double[] ans = new double[3];
            string[] root = new string[3];

            for (int i = 0; i < 3; i++)
            {
                ans[i] = -(B + Math.Pow(u, i) * CO + dis0 / (Math.Pow(u, i) * CO)) / 3 * A;
                root[i] = ans[i] + "+" + "i";
                Console.WriteLine(root[i]);
            }

            Console.ReadLine();
        }
    }
}
