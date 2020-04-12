using System;
//Дана строка, состоящая из строчных английских букв. Заменить в ней все буквы, стоящие после гласных, на следующие по алфавиту (z заменяется на a)
namespace laba21
{
    class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("Write text:");
            string s1 = Console.ReadLine();
            char [] s = s1.ToCharArray();
            for (int i = 0; i < s.Length-1; i++)
            {
                if (s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U' || s[i] == 'Y' ||
                    s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'y')
                {
                    if (s[i + 1] == ' ')
                    {
                        continue;
                    }

                    if (s[i + 1] == 'z')
                    { s[i + 1] = 'a';
                        i++;
                        continue;
                    }
                    
                    s[i+1]=(char)((int)s[i+1]+1);
                    i++;
                }
            }
            Console.WriteLine(s);
        }
    }
}
