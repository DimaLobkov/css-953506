using System;

namespace _2._3new
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = Console.ReadLine();
            char[] letters_arr = letters.ToCharArray();

            char[] vowels = {'a', 'e', 'i', 'o', 'u', 'y'};
            string vowels_str = vowels.ToString();

            int count = 0;
            
            foreach(char c in letters)
            {
                count++;           
                bool value = vowels_str.Contains(c);

                if(value)
                {
                    if(count-1==letters.Length-1)
                    {
                        break;
                    }
                    else
                    {
                        if(letters_arr[count]=='z')
                        {    
                            letters_arr[count]='a';   
                        }
                        else
                        {
                            letters_arr[count]++;
                        }
                    }
                }
            }           
            string singlestring = String.Join(" ",letters_arr); 
            Console.WriteLine(singlestring);
        }
    }
}
