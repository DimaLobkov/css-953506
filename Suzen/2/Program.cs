using System;
using System.Numerics;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("Choose the task from 1 to 3(for quit - 0):");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 0:
                        exit = true;
                        break;

                    case 1:
                        Console.Clear();
                        Console.WriteLine(DateTime.Now.ToString("dd MM yyyy HH:mm:ss"));
                        Console.WriteLine(DateTime.Now.ToString("dd MMMM yyyy hh:mm:ss"));
                        string nowDate = DateTime.Now.ToString();
                        int sum = 0;
                        for (char num = '0'; num <= '9'; num++)
                        {
                            for (int r = 0; r < nowDate.Length; r++)
                            {
                                if (nowDate[r] == num)
                                {
                                    sum++;
                                }
                            }

                            Console.WriteLine("{0}:{1}", num, sum);
                            sum = 0;
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        Random rnd = new Random();
                        string[] storage = { "a","b","c","d","e","f","g",
                                     "h","i","j","k","l","m","n",
                                     "o","p","q","v","r","s","t",
                                     "u","v","w","x","y","z"};
                        Console.Write("Random line: ");
                        for (int r = 0; r < 4; r++)
                        {
                            int letter = rnd.Next(storage.Length);
                            Console.Write(storage[letter]);
                        }
                        Console.Write("\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        Console.Write("Write interval [a,b]\na=");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("b=");
                        int b = Convert.ToInt32(Console.ReadLine());
                        BigInteger i;
                        for (i = 1; a <= b; a++)
                        {

                            i = i * a;

                        }
                        Console.Write("Your number :{0}\n", i);
                        int score = 0;
                        BigInteger j;
                        for (; ; )
                        {

                            j = i % 2;
                            i /= 2;
                            if (j == 0)
                            {
                                score++;
                            }
                            else break;

                        }
                        Console.Write("The highest degree of 2:{0}\n\n", score);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
