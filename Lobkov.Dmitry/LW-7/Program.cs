using System;
using System.Collections.Generic;

namespace _7
{
    class Fraction : IComparable, IEquatable<Fraction>
    {
        //поля
        private int _numerator;
        private int _denominator;

        //конструктор
        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        //методы
        private int EuclideanAlgorithm(int num1, int num2)
        {
            if (num1 % num2 == 0)
            {
                return num2;
            }

            if (num2 % num1 == 0)
            {
                return num1;
            }

            if (num1 > num2)
            {
                return EuclideanAlgorithm(num1 % num2, num2);
            }

            return EuclideanAlgorithm(num1, num2 % num1);
        }

        private void Simplify()
        {
            if (_numerator != 0)
            {
                int devider = EuclideanAlgorithm(Math.Abs(_numerator), Math.Abs(_denominator));
                _numerator /= devider;
                _denominator /= devider;
            }
        }

        //операторы
        public static Fraction operator +(Fraction num1, Fraction num2)
        {
            Fraction total = new Fraction(num1._numerator * num2._denominator + num2._numerator * num1._denominator, num1._denominator * num2._denominator);
            return total;
        }

        public static Fraction operator -(Fraction num1, Fraction num2)
        {
            Fraction total = new Fraction(num1._numerator * num2._denominator - num2._numerator * num1._denominator, num1._denominator * num2._denominator);
            return total;
        }

        public static Fraction operator *(Fraction num1, Fraction num2)
        {
            Fraction total = new Fraction(num1._numerator * num2._numerator, num1._denominator * num2._denominator);
            return total;
        }

        public static Fraction operator /(Fraction num1, Fraction num2)
        {
            Fraction total = new Fraction(num1._numerator * num2._denominator, num1._denominator * num2._numerator);
            return total;
        }

        public static explicit operator double(Fraction fr)
        {
            return (double)fr._numerator / fr._denominator;
        }

        public static implicit operator int(Fraction fr)
        {
            return fr._numerator / fr._denominator;
        }

        public int CompareTo(object obj)
        {
            Fraction anotherFraction = obj as Fraction;

            if ((double)_numerator / _denominator < anotherFraction)
                return -1;
            if ((double)_numerator / _denominator > anotherFraction)
                return 1;
            return 0;
        }

        public bool Equals(Fraction anotherFraction)
        {
            if (anotherFraction is null) 
            { 
                return false;
            }

            return (double)_numerator / _denominator == anotherFraction;
        }

        public static bool operator <(Fraction num1, Fraction num2)
        {
            double a = (double)num1, b = (double)num2;
            return a < b;
        }

        public static bool operator >(Fraction num1, Fraction num2)
        {
            double a = (double)num1, b = (double)num2;
            return a > b;
        }

        public static bool operator >=(Fraction num1, Fraction num2)
        {
            double a = (double)num1, b = (double)num2;
            return a >= b;
        }

        public static bool operator <=(Fraction num1, Fraction num2)
        {
            double a = (double)num1, b = (double)num2;
            return a <= b;
        }

        public static bool operator ==(Fraction num1, Fraction num2)
        {
            return num1.Equals((object)num2);
        }

        public static bool operator !=(Fraction num1, Fraction num2)
        {
            return !num1.Equals((object)num2);
        }

        public override string ToString()
        {
            Simplify();
            return ($"{_numerator}/{_denominator}");
        }

        //деструктор
        ~Fraction() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fraction firstNum, secondNum;
            int numerator, denominator;
            bool getOut = false;

            do
            {
                Console.WriteLine("Enter numerator and then denominator of the 1st number: ");
                int.TryParse(Console.ReadLine(), out numerator);
                int.TryParse(Console.ReadLine(), out denominator);
            } while ((numerator == 0) || (denominator == 0));

            firstNum = new Fraction(numerator, denominator);
            do
            {
                Console.WriteLine("Enter numerator and then denominator of the 2nd number: ");
                int.TryParse(Console.ReadLine(), out numerator);
                int.TryParse(Console.ReadLine(), out denominator);
            } while ((numerator == 0) || (denominator == 0));

            secondNum = new Fraction(numerator, denominator);
            do
            {
                int select;

                Console.Clear();
                do
                {
                    Console.WriteLine("1) Addition\n2) Substraction\n3) Composition\n4) Devision\n");
                    Console.WriteLine("5) <\n6) >\n7) <=\n8) >=\n9) ==\n10) !=\n11) Exit\nYour select: ");
                    int.TryParse(Console.ReadLine(), out select);
                    Console.Clear();
                } while (select == -1);
                switch (select)
                {
                    case 1:
                        Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum} = {(double)(firstNum + secondNum)}");
                        break;
                    case 2:
                        Console.WriteLine($"{firstNum} - {secondNum} = {firstNum - secondNum} = {(double)(firstNum - secondNum)}");
                        break;
                    case 3:
                        Console.WriteLine($"{firstNum} * {secondNum} = {firstNum * secondNum} = {(double)(firstNum * secondNum)}");
                        break;
                    case 4:
                        Console.WriteLine($"{firstNum} / {secondNum} = {firstNum / secondNum} = {(double)(firstNum / secondNum)}");
                        break;
                    case 5:
                        Console.WriteLine($"{firstNum} < {secondNum} is {firstNum < secondNum}");
                        break;
                    case 6:
                        Console.WriteLine($"{firstNum} > {secondNum} is {firstNum > secondNum}");
                        break;
                    case 7:
                        Console.WriteLine($"{firstNum} <= {secondNum} is {firstNum <= secondNum}");
                        break;
                    case 8:
                        Console.WriteLine($"{firstNum} >= {secondNum} is {firstNum >= secondNum}");
                        break;
                    case 9:
                        Console.WriteLine($"{firstNum} == {secondNum} is {firstNum == secondNum}");
                        break;
                    case 10:
                        Console.WriteLine($"{firstNum} != {secondNum} is {firstNum != secondNum}");
                        break;
                    case 11:
                        getOut = true;
                        break;
                    default:
                        Console.WriteLine("Something is wrong");
                        break;
                }

                Console.WriteLine("Press any key..");
                Console.ReadKey();
            } while (!getOut);

            Console.Clear();
            Console.WriteLine("Example");
            Fraction a = new Fraction(7, 3);
            Fraction b = new Fraction(-6, 5);
            Fraction c = new Fraction(3, 7);
            Fraction d = new Fraction(-5, 6);
            var list = new List<Fraction>() { a, b, c, d };

            foreach (var num in list)
            {
                Console.WriteLine(num.ToString());
            }

            list.Sort();
            Console.WriteLine("\nSorted nums:");
            foreach (var num in list)
            {
                Console.WriteLine(num.ToString());
            }

            Console.WriteLine();
        }
    }
}