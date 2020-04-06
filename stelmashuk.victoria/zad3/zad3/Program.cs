using System;

namespace labr2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, это программа выполняет эффективное перемешивание символов в веденной вами строке.");
            Console.WriteLine("Введите вашу строку: ");
            string text;
            text = Console.ReadLine();
            Console.WriteLine("Итак, строка в первоначальном виде: {0}", text);
                char[] array = text.ToCharArray();
                Random rng = new Random();
                int n = array.Length;
                while (n > 1)
                {
                    n--;
                    int k = rng.Next(n + 1);
                    var value = array[k];
                    array[k] = array[n];
                    array[n] = value;
                }
            text = new string(array);
            Console.WriteLine("Строка после перемешивания в ней символов: {0}", text);
        }
    }
}
