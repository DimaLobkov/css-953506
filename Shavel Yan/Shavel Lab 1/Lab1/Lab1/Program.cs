using System;
namespace KArdano
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Введите коэффициенты уравнения a*x^3+b*x^2+c*x+d=0 :");
            str = Console.ReadLine();

            string[] coefs = str.Split(' '); //Разложение строки на массив строк
            double[] numb = new double[4];

            for (int i = 0; i < coefs.Length; i++)
            {
                numb[i] = Convert.ToDouble(coefs[i]);  //Перевод из строки в double

            }

            double a = numb[0];
            double b = numb[1];
            double c = numb[2];
            double d = numb[3];

            int type = 0;
            double p1 = 0, p2 = 0, p3 = 0;
            Kardano(a, b, c, d, ref type, ref p1, ref p2, ref p3);
            if (type == 1)
                Console.WriteLine("x1={0} Re[x2,x3]={1} Im[x2,x3]={2}", p1, p2, p3); //Re=Real part Im=Imaginary part
            else
                Console.WriteLine("тип={0} p1={1} p2={2} p3={3}", type, p1, p2, p3);
            Console.ReadKey();
        }
            static void Kardano(double a, double b, double c, double d, ref int type, ref double r1, ref double r2, ref double r3)
        {
            double eps = 1E-14;
            double p = (3 * a * c - b * b) / (3 * a * a);
            double q = (2 * b * b * b - 9 * a * b * c + 27 * a * a * d) / (27 * a * a * a);
            double det = q * q / 4 + p * p * p / 27;
            if (Math.Abs(det) < eps)
                det = 0;
            if (det > 0)
            {
                type = 1; // один вещественный, два комплексных корня
                double u = -q / 2 + Math.Sqrt(det);
                u = Math.Exp(Math.Log(u) / 3);
                double yy = u - p / (3 * u);
                r1 = yy - b / (3 * a); // первый корень
                r2 = -(u - p / (3 * u)) / 2 - b / (3 * a);
                r3 = Math.Sqrt(3) / 2 * (u + p / (3 * u));
            }
            else
            {
                if (det < 0)
                {
                    type = 2; // три вещественных корня
                    double fi;
                    if (Math.Abs(q) < eps) // q=0
                        fi = Math.PI / 2;
                    else
                    {
                        if (q < 0) // q<0
                            fi = Math.Atan(Math.Sqrt(-det) / (-q / 2));
                        else // q<0
                            fi = Math.Atan(Math.Sqrt(-det) / (-q / 2)) + Math.PI;
                    }
                    double r = 2 * Math.Sqrt(-p / 3);
                    r1 = r * Math.Cos(fi / 3) - b / (3 * a);
                    r2 = r * Math.Cos((fi + 2 * Math.PI) / 3) - b / (3 * a);
                    r3 = r * Math.Cos((fi + 4 * Math.PI) / 3) - b / (3 * a);
                }
                else // при det=0
                {
                    if (Math.Abs(q) < eps)
                    {
                        type = 4; // 3-х кратный 
                        r1 = -b / (3 * a); // 3-х кратный 
                        r2 = -b / (3 * a);
                        r3 = -b / (3 * a);
                    }
                    else
                    {
                        type = 3; // один и два кратных вещественных
                        double u = Math.Exp(Math.Log(Math.Abs(q) / 2) / 3);
                        if (q < 0)
                            u = -u;
                        r1 = -2 * u - b / (3 * a);
                        r2 = u - b / (3 * a);
                        r3 = u - b / (3 * a);
                    }
                }
            }
        } // end Kardano
    }
}