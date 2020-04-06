using System;

namespace _2.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = DateTime.Now.ToString();
            char[] Str = str.ToCharArray();
            int n = 0;
            Console.WriteLine($"{str}");
            while (n < 10)
            {
                int j = 0;
                string c = Convert.ToString(n);
                char c1 = Convert.ToChar(c);
                for (int i = 0; i < str.Length; i++)
                {
                    if (Str[i] == c1)
                    {
                        j++;
                    }
                }
                Console.WriteLine($"There are {j} '{n}'");
                n++;
            }
            Console.WriteLine("\n\ncontinue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
