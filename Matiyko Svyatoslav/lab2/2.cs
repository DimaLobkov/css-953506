//Дана строка, слова в которой разделены пробелами.
//Вывести все слова, содержащие буквы, не входящие в английский алфавит. 
//Вывод должен быть выровнен по правому краю и иметь ширину самого длинного слова.

using System;

namespace lab2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string rus_alphabet="абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string words =Console.ReadLine();
            string[] split_words = words.Split(new char[]{' '});
            string[] truewords = new string [5];

            int count = 0;
            int true_count=0;
            
            foreach(string word in split_words)
            {
                foreach(char letter in word)
                {
                    string str_letter = letter.ToString();
                    bool c = rus_alphabet.Contains(str_letter);

                    if(c)
                    {
                        true_count++;
                        truewords[true_count-1]=split_words[count]  ; 
                        break;
                    } 
                }
                count ++;
            }
            string singlestring = String.Join(" ",truewords); 
            Console.WriteLine(singlestring);
            Console.ReadLine();
        }
    }
}
