using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            string[] words = str.Split(new char[] { ' ' });
 
            for (int i = words.Length - 1 ; i >= 0; i--)
            {
                Console.Write(words[i]);
                Console.Write(" ");
            }

            Console.ReadLine();
        }
    }
}
