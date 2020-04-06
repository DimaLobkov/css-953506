
using System;
using System.Numerics;

namespace lab11
{
    class Program
    {
        static void Main()
        {
            int correct = 0;

            do
            {
                Console.WriteLine("Вычислим корни кубического уравнения ");
                Console.WriteLine("Ax^3+Bx^2+Cx+D=0 ");
                Console.Write("A=");
                double A;
                while (!Double.TryParse(Console.ReadLine(), out A))
                {
                    Console.WriteLine("Ошибка ввода! Введите число A\nA= ");
                }
                   
                Console.Write("B=");
                double B;
                while (!Double.TryParse(Console.ReadLine(), out B))
                {
                    Console.WriteLine("Ошибка ввода! Введите число B\nB=");
                }
              
                Console.Write("C=");
                double C;
                while (!Double.TryParse(Console.ReadLine(), out C))
                {
                    Console.WriteLine("Ошибка ввода! C\nC=");
                }
               
                Console.Write("D=");
                double D;
                while (!Double.TryParse(Console.ReadLine(), out D))
                {
                    Console.WriteLine("Ошибка ввода! D\nD=");
                }
               
                Console.Clear();
                Console.WriteLine("A={0} B={1} C={2} D={3}", A, B, C, D);

                if (A == 0)
                {
                    Console.WriteLine("\nB={0}\t C={1}\t D={2}\n ",  B, C, D);

                    double Des = Math.Pow(C, 2) - 4 * B * D;
                    double N = Math.Pow(Des, 0.5);
                    double x1 = (-B + N) / 2 * B;
                    double x2 = (-B - N) / 2 * B;
                    Console.WriteLine("\nДаскриминант Des= {0} ", Des);
                    
                    if (Des >= 0)
                    {
                        Console.WriteLine("\nПервый корень x1= {0} ", x1);
                        Console.WriteLine("\nВторой корень x2= {0} ", x2);
                    }
                    
                    else if (Des < 0)
                    {
                        Console.WriteLine("Второй корень x2= (-{1} + i * {0})/2 * {2} ", N, B, C);
                        Console.WriteLine("Третий корень x3= (-{1} - i * {0})/2 * {2} ", N, B, C);
                    }
                }
                
                else
                {
                    Console.Write("\nДелим все коэфиценты на А:");
                    B /= A;
                    C /= A;
                    D /= A;
                    A = 1;
                    Console.WriteLine("\nA={0}\t B={1}\t C={2}\t D={3}\n ", A, B, C, D);

                    double Q = (Math.Pow(B, 2.0) - (3 * C)) / 9.0;
                    double R = ((2 * Math.Pow(B, 3.0)) - (9 * B * C) + (27 * D)) / 54.0;
                    double S = Math.Pow(Q, 3) - Math.Pow(R, 2);

                    Console.WriteLine("Q={0} \t R={1} \t S={2}\n ", Q, R, S);

                    if (S > 0)
                    {
                        double fi = Math.Acos(R / Math.Sqrt(Math.Pow(Q, 3.0))) / 3.0;
                        double x1 = -2 * Math.Sqrt(Q) * Math.Cos(fi) - (B / 3.0);
                        Console.WriteLine("\nПервый корень x1= {0} ", x1);
                        double x2 = -2 * Math.Sqrt(Q) * Math.Cos(fi + ((2 * Math.PI) / 3.0)) - (B / 3.0);
                        Console.WriteLine("Второй корень x2= {0} ", x2);
                        double x3 = -2 * Math.Sqrt(Q) * Math.Cos(fi - ((2 * Math.PI) / 3.0)) - (B / 3.0);
                        Console.WriteLine("Третий корень x3= {0} ", x3);
                    }

                    int znakR;

                    if (R < 0) { znakR = -1; }
                    else if (R > 0) { znakR = 1; }
                    else { znakR = 0; };

                    if (S < 0 && Q > 0)
                    {
                        double value1 = (Math.Abs(R) / Math.Sqrt(Math.Abs(Math.Pow(Q, 3))));
                        if (value1 < 0) Console.WriteLine("ERROR...");
                        else
                        {
                            double value2 = (value1 + Math.Sqrt(Math.Pow(value1, 2) - 1));
                            double Arch = Math.Log(value2, Math.E);
                            double fi = Arch / 3.0;
                            double ch = (Math.Pow(Math.E, fi) + Math.Pow(Math.E, -fi)) / 2.0;
                            double value3 = Math.Sqrt(Q) * ch;
                            double x1 = -2 * znakR * value3 - (B / 3.0);

                            Console.WriteLine("\nПервый корень x1= {0} ", x1);

                            double x2 = (znakR * Math.Sqrt(Q) * Math.Cosh(fi)) - (B / 3.0);
                            double x3 = Math.Sqrt(3) * Math.Sqrt(Q) * Math.Sinh(fi);

                            Console.WriteLine("Второй корень x2= {0} + {1} * i ", x2, x3);
                            Console.WriteLine("Третий корень x3= {0} - {1} * i ", x2, x3);
                        }
                    }

                    else if (S < 0 && Q < 0)
                    {
                        double value1 = (Math.Abs(R) / Math.Sqrt(Math.Abs(Math.Pow(Q, 3))));
                        double value2 = (value1 + Math.Sqrt(Math.Pow(value1, 2) + 1));
                        double Arsh = Math.Log(value2, Math.E);
                        double fi = Arsh / 3.0;
                        double sh = (Math.Pow(Math.E, fi) - Math.Pow(Math.E, -fi)) / 2.0;
                        double value3 = Math.Sqrt(Math.Abs(Q)) * sh;
                        double x1 = -2 * znakR * value3 - (B / 3.0);

                        Console.WriteLine("\nПервый корень x1= {0} ", x1);

                        double x2 = (znakR * Math.Sqrt(Math.Abs(Q)) * Math.Sinh(fi)) - (B / 3.0);
                        double x3 = Math.Sqrt(3) * Math.Sqrt(Math.Abs(Q)) * Math.Cosh(fi);

                        Console.WriteLine("Второй корень x2= {0} + {1} * i ", x2, x3);
                        Console.WriteLine("Третий корень x3= {0} - {1} * i ", x2, x3);
                    }

                    else if (S < 0 && Q == 0)
                    {
                        double x1 = -Math.Pow(D - (Math.Pow(B, 3) / 27.0) - (B / 3.0), 1 / 3.0);

                        Console.WriteLine("\nПервый корень x1= {0} ", x1);

                        double x2 = -(B + x1) / 2.0;
                        double x3 = Math.Sqrt(Math.Abs(((B - 3 * x1) * (B + x1)) - 4 * C)) / 2.0;

                        Console.WriteLine("Второй корень x2= {0} + {1} * i ", x2, x3);
                        Console.WriteLine("Третий корень x3= {0} - {1} * i ", x2, x3);
                    }

                    if (S == 0)
                    {
                        double x1 = (-2 * Math.Pow(R, 1 / 3.0)) - (B / 3.0);
                        Console.WriteLine("\nПервый корень x1= {0} ", x1);
                        double x2 = (Math.Pow(R, 1 / 3.0)) - (B / 3.0);
                        Console.WriteLine("Второй корень x2= {0} ", x2);
                    }
                }
                Console.Write("\nЧтобы продолжить нажмите 1\n ");
                correct = Convert.ToInt32(Console.ReadLine());
                if (correct == 1) Console.Clear();
            } while (correct == 1);

        }

    }

}