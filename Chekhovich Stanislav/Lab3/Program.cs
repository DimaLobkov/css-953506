using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            uint K = 1;
            uint a;
            bool exit = false;
            Firearm Gun = new Firearm();
            while (true)
            {
                Console.WriteLine("1.Create a new firearm" +
                    "\n2.Shoot a firearm" +
                    "\n3.Realod a firearm" +
                    "\n4.Info about gun" +
                    "\n5.Exit the program");
                if (!UInt32.TryParse(Console.ReadLine(), out K))
                {
                    Console.WriteLine("Error");
                    break;
                }
                Console.Clear();
                switch (K)
                {
                    case 1:
                        {
                            Console.Write("Write model of your weapon: ");
                            Gun.Model = Console.ReadLine();
                            Console.Write("Write caliber of your weapon: ");
                            Gun.Caliber = Console.ReadLine();
                            Console.Write("Write max ammo in a clip: ");
                            if(!UInt32.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Error");
                                break;
                            }
                            Gun.MaxAmmo = a;
                            Console.Write("Write current ammo in a clip: ");
                            if (!UInt32.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Error");
                                break;
                            }
                            Gun.AmmoInClip = a;
                            break;
                        }
                    case 2:
                        {
                            while (!Gun.Reload)
                            {
                                Gun.Shoot();
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("How many ammo do you want to reload?" +
                                "\n1.Full clip" +
                                "\n2.My number");
                            uint k;
                            if (!UInt32.TryParse(Console.ReadLine(), out k))
                            {
                                Console.WriteLine("Error");
                                break;
                            }
                            if(k == 1)
                            {
                                Gun.Reload = false;
                            }
                            else if ( k == 2)
                            {
                                Console.WriteLine("What number?");
                                if (!UInt32.TryParse(Console.ReadLine(), out k))
                                {
                                    Console.WriteLine("Error");
                                    break;
                                }
                                Gun.ReloadFirearm(k);
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine(Firearm.GeneralInfo);
                            Console.WriteLine($"Model of your weapon: {Gun.Model}");
                            Console.WriteLine($"Caliber of your weapon: {Gun.Caliber}");
                            Console.WriteLine($"Max ammo in a clip: {Gun.MaxAmmo}");
                            Console.WriteLine($"Current ammo in a clip: {Gun.AmmoInClip}");
                            break;
                        }
                    case 5:
                        {
                            exit = true;
                            break;
                        }
                    default:
                        break;
                }
                if (exit == true)
                {
                    break;
                }
                Console.WriteLine("\nPress any button...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
