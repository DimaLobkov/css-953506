using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();

            Console.WriteLine("Заглавные буквы не входящие в английский алфавит:");
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'А') Console.WriteLine(str[i]);
                if (str[i] == 'Б') Console.WriteLine(str[i]);
                if (str[i] == 'В') Console.WriteLine(str[i]);
                if (str[i] == 'Г') Console.WriteLine(str[i]);
                if (str[i] == 'Д') Console.WriteLine(str[i]);
                if (str[i] == 'Е') Console.WriteLine(str[i]);
                if (str[i] == 'Ё') Console.WriteLine(str[i]);
                if (str[i] == 'Ж') Console.WriteLine(str[i]);
                if (str[i] == 'З') Console.WriteLine(str[i]);
                if (str[i] == 'И') Console.WriteLine(str[i]);
                if (str[i] == 'Й') Console.WriteLine(str[i]);
                if (str[i] == 'К') Console.WriteLine(str[i]);
                if (str[i] == 'Л') Console.WriteLine(str[i]);
                if (str[i] == 'М') Console.WriteLine(str[i]);
                if (str[i] == 'Н') Console.WriteLine(str[i]);
                if (str[i] == 'О') Console.WriteLine(str[i]);
                if (str[i] == 'П') Console.WriteLine(str[i]);
                if (str[i] == 'Р') Console.WriteLine(str[i]);
                if (str[i] == 'С') Console.WriteLine(str[i]);
                if (str[i] == 'Т') Console.WriteLine(str[i]);
                if (str[i] == 'У') Console.WriteLine(str[i]);
                if (str[i] == 'Ф') Console.WriteLine(str[i]);
                if (str[i] == 'Х') Console.WriteLine(str[i]);
                if (str[i] == 'Ц') Console.WriteLine(str[i]);
                if (str[i] == 'Ч') Console.WriteLine(str[i]);
                if (str[i] == 'Ш') Console.WriteLine(str[i]);
                if (str[i] == 'Щ') Console.WriteLine(str[i]);
                if (str[i] == 'Э') Console.WriteLine(str[i]);
                if (str[i] == 'Ю') Console.WriteLine(str[i]);
                if (str[i] == 'Я') Console.WriteLine(str[i]);
            }


            Console.ReadLine();
        }
    }
}
