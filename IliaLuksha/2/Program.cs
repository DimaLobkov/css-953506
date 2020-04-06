/*
 *Реализовать вычисление параметров треугольника
 * (стороны, углы, периметр, площадь, радиусы вписанной и описанной окружностей, …)
 * по трем заданным параметрам
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMathClass
{
    namespace ConsoleApp1
    {
        class Program
        {
            static void Main(string[] args)
            {
                double P = 0, S = 0, cosa = 0, cosb = 0, cosc = 0 , p = 0, m_a = 0, m_b = 0, m_c = 0;
                double b_a = 0, b_b = 0, b_c = 0, h_a = 0, h_b = 0, h_c = 0, sr_a = 0, sr_b = 0, sr_c = 0;
                double R = 0, r = 0;

                Console.WriteLine("Enter sids of the triangle(a, b, c): ");
                int a = Int32.Parse(Console.ReadLine());
                int b = Int32.Parse(Console.ReadLine());
                int c = Int32.Parse(Console.ReadLine());

                if ( (a < b + c) && (b < a + c) && (c < a + b))
                {
                    P = a + b + c;
                    p = P / 2;

                    S = Math.Pow(p * (p - a) * (p - b) * (p - c), 0.5) / 2;

                    cosa = (Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c);
                    cosb = (Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c);
                    cosc = (Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b);

                    m_a = (Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / 2;
                    m_b = (Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / 2;
                    m_c = (Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / 2;

                    b_a = Math.Pow(b * c * (a + b + c) * (b + c - a), 0.5) / (b + c);
                    b_b = Math.Pow(a * c * (a + b + c) * (b + c - b), 0.5) / (a + c);
                    b_c = Math.Pow(a * b * (a + b + c) * (a + b - c), 0.5) / (a + b);

                    h_a = 2 * Math.Pow(p * (p - a) * (p - b) * (p - c), 0.5) / a;
                    h_b = 2 * Math.Pow(p * (p - a) * (p - b) * (p - c), 0.5) / b;
                    h_c = 2 * Math.Pow(p * (p - a) * (p - b) * (p - c), 0.5) / c;

                    sr_a = a / 2;
                    sr_b = b / 2;
                    sr_c = c / 2;

                    r = Math.Pow((p - a) * (p - b) * (p - c) / p, 0.5);
                    R = a * b * c / (4 * Math.Pow((p * (p - a) * (p - b) * (p - c)), 0.5));

                    Console.WriteLine($"Square = {S}, Perimeter = {P}, Half-perimeter = {p}");
                    Console.WriteLine($"cos<A = {cosa}, cos<B = {cosb}, cos<C = {cosc}");
                    Console.WriteLine($"Median omitted on the side: a = {m_a}, b = {m_b}, c = {m_c}");
                    Console.WriteLine($"Height omitted on the side: a = {h_a}, b = {h_b}, c = {h_c}");
                    Console.WriteLine($"Medium Line opposite side: a = {sr_a}, b = {sr_b}, c = {sr_c}");
                    Console.WriteLine($"Radius of iscripbed circle = {r}");
                    Console.WriteLine($"Radius od the described circle = {R}");
                }

                else
                {
                    Console.WriteLine("There is no triangle with such sides");
                }
            }
        }
    }
}
