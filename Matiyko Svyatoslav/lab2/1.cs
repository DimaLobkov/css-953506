// Дана строка, слова в которой разделены пробелами. 
// Есть знаки препинания, которые записаны сразу после слова.
// Добавить перед каждым словом тот знак препинания, который стоит после него.

using System;

namespace lab2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            string[] str_words= words.Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
            int count=0;
            foreach(string str in str_words)
            {
                if(str[str.Length-1]==','||str[str.Length-1]=='.')
                {
                    char pad=str[str.Length-1];
                    str_words[count]=str.PadLeft(str.Length+1,pad);
                    count++;
                }
                else
                {
                    count++;
                }
            }
            string singlestring = String.Join(" ",str_words); 
            Console.WriteLine(singlestring);
            Console.ReadLine();
        }
    }
}
