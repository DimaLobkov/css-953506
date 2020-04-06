/*
 * Дана строка. Найти в ней все заглавные буквы, не входящие в английский алфавит. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Char {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the string:");
                string a = Console.ReadLine();

                int n = a.Length;
                char[] mas = a.ToCharArray();

                Console.WriteLine("All cappital letters that are not part of the English alphabet: ");
                for (int i = 0; i < n; i++)
                {
                    if (char.IsUpper(mas[i]) )
                    {
                        if(mas[i] >= 'A' && mas[i] <= 'Z'){}
                        else
                        {
                            Console.WriteLine($"{mas[i]} ");
                        }
                    }
                }

            }
        }
    }
}
