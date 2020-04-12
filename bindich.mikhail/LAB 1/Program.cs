using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1{
    class Program{

        static string[] myParse(string exprString) // Функция разбивает строку с выражением на подстроки по скобкам
        {
            string[] result = new string[3];

            string tmpString = exprString.Substring(exprString.LastIndexOf('(') + 1, exprString.Length - exprString.LastIndexOf('(') - 1);
            Console.WriteLine(tmpString);

            result[0] = exprString.Substring(0, exprString.LastIndexOf('('));
            result[1] = tmpString.Substring(0, tmpString.IndexOf(')'));
            result[2] = tmpString.Substring(tmpString.IndexOf(')') + 1, tmpString.Length - tmpString.IndexOf(')') - 1);

            return result;
        }

        static double myCalc(string exprString) // Рекурсивная функция, вычисляет само выражение
        {
            string [] tmp;
            double res = 0;
            
            if (exprString.Contains('('))
            {
                string[] parts = myParse(exprString); // Если в выражении содержится открывающая скобка, то передаём в myParse строку с выражением, на выходе получаем массив строк, 
                                                      // в которой 0 элемент - до первой открывающей скобки, 2 - после последней открывабщей скобки, 1 - от первой открывающей до последней закрывающей
                double brackets = myCalc(parts[1]);     // Далее рекурсивно вызываем myCalc, в которую передаём строку 1 (часть выражения в скобках)
                string newExprString = parts[0] + brackets.ToString() + parts[2]; // Склеиваем полученное выражение в строку и передаём в myCalc
                return myCalc(newExprString);
            }

            if (exprString.Contains('+')) // Если есть "+", то разбиваем строку по этому символу и складываем с res переданные в myCalc подстроки
            {
                tmp = exprString.Split('+');
                for (int i = 0; i < tmp.Length; i++)
                {
                    res += myCalc (tmp[i]);
                }
                return res;
            }

            if (exprString.Contains('-')) // Алгоритм тот же, что и с "+", за исключением того, что перед циклом мы присваиваем res подстроку до первого "-"
            {
                tmp = exprString.Split('-');
                res = myCalc (tmp[0]);
                for (int i = 1; i < tmp.Length; i++)
                {
                    res -= myCalc(tmp[i]);
                }
                return res;
            }

            if (exprString.Contains('*')) // Алгоритм тот же, что и с "+", за исключением того, что перед циклом мы присваиваем res 1
            {
                tmp = exprString.Split('*');
                res = 1;
                for (int i = 0; i < tmp.Length; i++)
                {
                    res *= myCalc(tmp[i]);
                }
                return res;
            }

            if (exprString.Contains('/')) // Алгоритм тот же, что и с "+", за исключением того, что перед циклом мы присваиваем res подстроку до первого "/"
            {
                tmp = exprString.Split('/');
                res = myCalc(tmp[0]);
                for (int i = 1; i < tmp.Length; i++)
                {
                    res /= myCalc(tmp[i]);
                }
                return res;
            }

            return Convert.ToDouble(exprString.Trim());
        }

        static void Main(string[] args){

            Console.WriteLine("Enter expression (without spaces):");
            string maneString = Console.ReadLine();

            Regex rexpr = new Regex(@"[^\(\)\d\+\-\*\/]"); 
            while (rexpr.IsMatch(maneString))   // Проверка правильности ввода строки
            {
                Console.WriteLine("Invalid string format, please try again");
                maneString = Console.ReadLine();
            }

            double result = myCalc(maneString);

            Console.Write("The result is: ");
            Console.WriteLine(result);
        }
    }
}
