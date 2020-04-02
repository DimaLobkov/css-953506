using System;

namespace Lab3
{
    class Firearm
    {
        private string model;
        private string caliber;
        private uint max_ammo;
        private uint ammo_in_clip;
        private bool reload;
        private static string general_info = "Firearm weapon use ammo to shoot";
        static public string GetGeneral_Info()
        {
            return general_info;
        }
        public bool GetReload()
        {
            return reload;
        }
        public void SetModel(string model)
        {
            this.model = model;
        }
        public void SetCaliber(string caliber)
        {
            this.caliber = caliber;
        }
        public void SetMax_Ammo(uint max_ammo)
        {
            this.max_ammo = max_ammo;
        }
        public void SetAmmo_In_Clip(uint ammo_in_clip)
        {
            this.ammo_in_clip = ammo_in_clip;
            if(ammo_in_clip == 0)
            {
                reload = true;
            }
            else
            {
                reload = false;
            }
        }
        public string GetModel()
        {
            return model;
        }
        public string GetCaliber()
        {
            return caliber;
        }
        public uint GetMax_Ammo()
        {
            return max_ammo;
        }
        public uint GetAmmo_In_Clip()
        {
            return ammo_in_clip;
        }

        public Firearm()
        {
            model = "M16";
            caliber = "5,56";
            max_ammo = 30;
            ammo_in_clip = 30;
        }

        public void Reload()
        {
            ammo_in_clip = max_ammo;
            reload = false;
        }
        public void Reload(uint ammo)
        {
            if (ammo > max_ammo)
            {
                ammo_in_clip = max_ammo;
            }
            else
            {
                ammo_in_clip = ammo;
            }
            reload = false;
        }
        public void Shoot()
        {
            if (ammo_in_clip > 0)
            {
                ammo_in_clip -= 1;
                Console.WriteLine($"PAU! Ammo in clip: {ammo_in_clip}/{max_ammo}");
            }
            else
            {
                reload = true;
            }
        }
    }
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
                            Gun.SetModel(Console.ReadLine());
                            Console.Write("Write caliber of your weapon: ");
                            Gun.SetCaliber(Console.ReadLine());
                            Console.Write("Write max ammo in a clip: ");
                            if(!UInt32.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Error");
                                break;
                            }
                            Gun.SetMax_Ammo(a);
                            Console.Write("Write current ammo in a clip: ");
                            if (!UInt32.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Error");
                                break;
                            }
                            Gun.SetAmmo_In_Clip(a);
                            break;
                        }
                    case 2:
                        {
                            while (!Gun.GetReload())
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
                                Gun.Reload();
                            }
                            else if ( k == 2)
                            {
                                Console.WriteLine("What number?");
                                if (!UInt32.TryParse(Console.ReadLine(), out k))
                                {
                                    Console.WriteLine("Error");
                                    break;
                                }
                                Gun.Reload(k);
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine(Firearm.GetGeneral_Info());
                            Console.WriteLine($"Model of your weapon: {Gun.GetModel()}");
                            Console.WriteLine($"Caliber of your weapon: {Gun.GetCaliber()}");
                            Console.WriteLine($"Max ammo in a clip: {Gun.GetMax_Ammo()}");
                            Console.WriteLine($"Current ammo in a clip: {Gun.GetAmmo_In_Clip()}");
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
