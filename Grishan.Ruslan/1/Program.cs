using System;
using System.Text;
namespace First
//строчный калькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите выражение:");
            StringBuilder vir = new StringBuilder();
            StringBuilder chislo1 = new StringBuilder();
            StringBuilder chislo2 = new StringBuilder();
            StringBuilder result = new StringBuilder();
            char z;
            int count = 0;
            vir.Append(Console.ReadLine());
            for (int i = 0; i < vir.Length; i++)
            {
                if (vir[i] == '*'|| vir[i] == '/')
                {
                    z = vir[i];
                    count = i;
                    for (i++; ((i < vir.Length) && (char.IsNumber(vir[i]))); i++)                                  //число после знака
                    {
                        chislo2.Append(vir[i]);
                    }
                    for (count--; ((count >= 0) && (char.IsNumber(vir[count]))); count--)
                    {
                        chislo1.Insert(0, vir[count]);                                                   //число до знака
                    }
                    int ch2 = int.Parse(chislo2.ToString());
                    int ch1 = int.Parse(chislo1.ToString());                                                 //конвертирую строки в числа
                    if (z=='*')
                    result.Append(ch1 * ch2);
                    else
                    result.Append(ch1 / ch2);
                    chislo1.Append(z);
                    chislo1.Append(chislo2);
                    vir.Replace(chislo1.ToString(), result.ToString());                                      //заменяю выражение

                    i = 0;
                    chislo1 = new StringBuilder();                                                      //очищаю строки
                    chislo2 = new StringBuilder();
                    result = new StringBuilder();
                }
            }
            for (int i = 0; i < vir.Length; i++)
            {
                if (vir[i] == '+' || vir[i] == '-')
                {
                    z = vir[i];
                    count = i;
                    for (i++; ((i < vir.Length) && (char.IsNumber(vir[i]))); i++)                                  //число после знака
                    {
                        chislo2.Append(vir[i]);
                    }
                    for (count--; ((count >= 0) && (char.IsNumber(vir[count]))); count--)
                    {
                        chislo1.Insert(0, vir[count]);                                                   //число до знака
                    }
                    int ch2 = int.Parse(chislo2.ToString());
                    int ch1 = int.Parse(chislo1.ToString());                                                 //конвертирую строки в числа
                    if (z == '+')
                        result.Append(ch1 + ch2);
                    else
                        result.Append(ch1 - ch2);
                    chislo1.Append(z);
                    chislo1.Append(chislo2);
                    vir.Replace(chislo1.ToString(), result.ToString());                                      //заменяю выражение

                    i = 0;
                    chislo1 = new StringBuilder();                                                      //очищаю строки
                    chislo2 = new StringBuilder();
                    result = new StringBuilder();
                }
            }
            Console.Write("="+vir);      
        }
    }
}
