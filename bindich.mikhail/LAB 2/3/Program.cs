using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _2_3
{
    class Program
    {
        static StringBuilder stringModifier(string[] words)
        {
            StringBuilder sbRes = new StringBuilder("");
            Regex regExpr = new Regex(@"([^A-z])+");

            for (int i = 0; i < words.Length; i++)
            {
                StringBuilder tmp = new StringBuilder("");
                if (regExpr.IsMatch(words[i]))
                {
                    sbRes.Append(tmp.Insert(0, regExpr.Match(words[i])));
                }
                if (i == words.Length - 1)
                {
                    sbRes.Append(words[i]);
                }
                else
                {
                    sbRes.Append(words[i] + ' ');
                }
            }
            return sbRes;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string maneStr;
            maneStr = Console.ReadLine();
            string[] words = maneStr.Split(' ');
            StringBuilder sb = new StringBuilder("");
            sb = stringModifier(words);
            Console.WriteLine($"The result string: {sb}");
        }
    }
}
