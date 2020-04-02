using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string d = Console.ReadLine();
            string[] words = d.Split(' ');//расщепляет на слова
            foreach (string st in words)////вывод всех слов в words
                    Array.Reverse(words);// слова в words в обратном порядке
              Console.WriteLine("reversed:");
           for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }
         Console.ReadKey();
        }
    }
}
