using System;
//Дана строка, слова в которой разделены пробелами. 
//Есть знаки препинания, кото-рые записаны сразу после слова. 
//Добавить перед каждым словом тот знак препина-ния, который стоит после него.
namespace laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write text:");
            string s1 = Console.ReadLine();
            s1.ToCharArray();
            char []a = new char[999];
            for (int i = 0; i < a.Length; i++)
                a[i] = '\0';
            for (int i = 0; i < s1.Length; i++)
                a[i] = s1[i];
            int check, nem=0;
            char simbol;
            for (int i = 0; a[i] != '\0';i++)
            {
                
                if (Char.IsPunctuation(a[i]))
                {
                    simbol = a[i];
                    int n = i;
                    n--;
                    while (Char.IsLetter(a[n]))
                    {
                        n--;
                    }
                    check = n;
                    n++;
                    do { nem++; }
                    while (a[nem + 1] != '\0');
                    
                    for (nem++; nem >= n; nem--)
                    {
                         a[nem] = a[nem - 1]; 
                    }
                    a[n] = simbol;
                    i++;
                }
            }
            Console.WriteLine(a);
        }
    }
}
