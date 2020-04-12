using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();

            string[] strArr;
            strArr = str.Split(' ');
            string result = "";
            for (int i = strArr.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    result += strArr[i];
                    break;
                }
                else
                {
                    result += strArr[i] + ' ';
                }
            }

            Console.WriteLine(result);
        }
    }
}
