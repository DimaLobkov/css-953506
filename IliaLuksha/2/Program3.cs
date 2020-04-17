/*
 * Дана строка, состоящая из строчных английских букв.
 * Заменить в ней все буквы, стоящие после гласных, на следующие по алфавиту (z заменяется на a). 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] mas = s.ToCharArray();
            int n = s.Length;

            for(int i = 0; i < n - 1; i++)
            {
                switch (s[i])
                {
                    case 'a':
                    case 'e': 
                    case 'i': 
                    case 'o': 
                    case 'u': 
                    case 'y':
                            if (char.IsDigit(s[i + 1]) == false)//IsAlpha
                            {
                                
                                    if (Convert.ToInt32(mas[i + 1]) == 122)
                                    {
                                        mas[i + 1] = Convert.ToChar(97);
                                    }
                                    else
                                    {
                                        int c = Convert.ToInt32(s[i + 1]) + 1;
                                        mas[i + 1] = Convert.ToChar(c);
                                    }
                            
 
                            }
                            break;
                        default: break;
                }

            }

            for(int i = 0; i < n; i++)
            {
                Console.Write(mas[i]);
            }
        }
    }
}


