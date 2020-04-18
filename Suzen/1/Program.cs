using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
namespace ConsoleApp1

{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> count1 = new List<int>() { 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 9, 10, 10, 10, 10, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 11, 11, 11, 11 };
            bool ifer = false;
            int randomer = 0, Sum = 0, check = 0, randomer2 = 0, Sum2 = 0, rand2 = 0, a = 35;
            Random rand = new Random();

            if (!ifer)
            {
                while (true)
                {
                    rand2 = rand.Next() % 2;
                    if (rand2 == 1)
                    {
                        Sum2++;
                    }
                    else
                    {
                        Sum2--;
                    }
                    randomer = rand.Next() % a;
                    Sum += count1[randomer];
                    randomer2 = rand.Next() % a;
                    Sum2 += count1[randomer];

                    Console.WriteLine("Your cart is");
                    switch (count1[randomer])
                    {
                        case 6:
                            Console.WriteLine("|6|");
                            break;
                        case 7:
                            Console.WriteLine("|7|");
                            break;
                        case 8:
                            Console.WriteLine("|8|");
                            break;
                        case 9:
                            Console.WriteLine("|9|");
                            break;
                        case 10:
                            Console.WriteLine("|10|");
                            break;
                        case 3:
                            Console.WriteLine("|J|");
                            break;
                        case 4:
                            Console.WriteLine("|Q|");
                            break;
                        case 5:
                            Console.WriteLine("|K|");
                            break;
                        case 11:
                            Console.WriteLine("|A|");
                            break;
                    }
                    count1.RemoveAt(randomer);
                    a--;

                    Console.WriteLine("You have {0} points", Sum);
                    if (Sum2 > 21 && Sum < 21)
                    {
                        Console.WriteLine("YOU WIN");
                        ifer = true;
                        break;

                    }
                    if (Sum > 21)
                    {
                        Console.WriteLine("YOU LOSE");
                        ifer = true;
                        break;
                    }

                    if (Sum == 21)
                    {
                        Console.WriteLine("YOU WIN");
                        ifer = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Do you want to take one more card?");
                        Console.WriteLine("|YES(1)|NO(0)|");
                        check = Convert.ToInt32(Console.ReadLine());
                        if (check == 0)
                        {
                            Console.WriteLine("Computer have {0} points", Sum2);

                            if (Sum > Sum2)
                            {
                                Console.WriteLine("YOU WIN");
                                ifer = true;
                                break;
                            }
                            else
                            {
                                if (Sum == Sum2)
                                {
                                    Console.WriteLine("IT IS A DRAW");
                                    ifer = true;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("YOU LOSE");
                                    ifer = true;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
