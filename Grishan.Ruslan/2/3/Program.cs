using System;
//Дана строка, содержащая число с десятичной точкой. 
//Преобразовать эту строку в число действительного типа (не пользуясь стандартным Parse/TryParse). 
namespace laba22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write number:");
            int Ni = 0;
            string number1 = Console.ReadLine();
            char[] number = number1.ToCharArray();
            while (number[Ni] != '.')
            { 
                Ni++; 
            }
            int Nd = number.Length-Ni-1;
            int[] celoe = new int[Ni];
            int[] drob = new int[Nd];
            for (int i = 0; i < Ni; i++)
            {
                celoe[i] = ((int)number[i] - '0');
            }
            for (int i = (Ni + 1), j = 0; (i < number.Length) && (j < Nd); i++, j++)
            {
                drob[j] = ((int)number[i] - '0');
            }
            float cel=0f, n=1f, dro=0f;
            for (int i = Ni - 1; i >= 0; i--, n *= 10)
            {
                cel += celoe[i] * n;
            }
            n = 10;
            for (int i = 0; i < Nd; i++, n *= 10)
            {
                dro += drob[i] / n;
            }
            float chislo = cel + dro;
            Console.WriteLine(chislo);
        }
    }
}
