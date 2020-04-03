using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
namespace ConsoleApp1

{
    namespace System.Char
    {
        class Program
        {
            static void Main(string[] args)
            {
                int[] count = { 6, 7, 8, 9, 10, 3, 4, 5, 11 };
                bool ifer = false;
                int randomer = 0, Sum = 0, check = 0, randomer2 = 0, Sum2 = 0, rand2 = 0;
                Random rand = new Random();

                while (true)
                {
                    if (!ifer)
                    {
                        rand2 = rand.Next() % 2;
                        if(rand2 == 1)
                        {
                            Sum2++;
                        }
                        else
                        {
                            Sum2--;
                        }
                        randomer = rand.Next() % 9;
                        Sum += count[randomer];
                        randomer2 = rand.Next() % 9;
                        Sum2 += count[randomer];
                        Console.WriteLine("You got ");
                        switch (count[randomer])
                        {
                            case 6:
                                Console.WriteLine("6");
                                break;
                            case 7:
                                Console.WriteLine("7");
                                break;
                            case 8:
                                Console.WriteLine("8");
                                break;
                            case 9:
                                Console.WriteLine("9");
                                break;
                            case 10:
                                Console.WriteLine("10");
                                break;
                            case 3:
                                Console.WriteLine("Jack");
                                break;
                            case 4:
                                Console.WriteLine("Queen");
                                break;
                            case 5:
                                Console.WriteLine("King");
                                break;
                            case 11:
                                Console.WriteLine("ACE");
                                break;
                        }
                        Console.WriteLine($"You have {Sum} points");
                        if(Sum2 > 21 && Sum < 21)
                        {
                            Console.WriteLine("You WIN");
                            ifer = true;
                           
                        }
                        if (Sum > 21)
                        {
                            Console.WriteLine("LOSE");
                            ifer = true;
                            break;
                        }
                        if (Sum == 21)
                        {
                            Console.WriteLine("You WIN");
                            ifer = true;
                        }
                        else
                        {
                            Console.WriteLine("Do you want to take another card?");
                            Console.WriteLine("#Yes(1)#  #No(0)#");
                            check = Convert.ToInt32(Console.ReadLine());
                            if (check == 0)
                            {
                                Console.WriteLine($"Computer have {Sum2} points");
                                
                                if (Sum > Sum2)
                                {
                                    Console.WriteLine("You WIN");
                                    ifer = true;
                                }
                                else
                                {
                                    if(Sum == Sum2)
                                    {
                                        Console.WriteLine("DRAW");
                                        ifer = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("LOSE");
                                        ifer = true;
                                    }
                                }
                            }
                        }

                    }

                }
            }
        }
    }
}
