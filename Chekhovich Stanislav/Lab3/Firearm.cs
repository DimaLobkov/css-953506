using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{               
    class Firearm
    {
        private bool ModeSingle { get; set; } = true;
        private bool ModeBirst { get; set; } = false;
        private bool ModeAuto { get; set; } = false;
        public uint AmmoInClip { get; set; }
        public uint MaxAmmo { get; set; }
        public string Model { get; set; }
        public string Caliber { get; set; }
        public bool IsReloaded { get; set; }
        public bool IsSafetyOn { get; set; } = true;
        
        //Индексатор
        public bool this[string mode]
        {
            get
            {
                switch(mode)
                {
                    case "Single":
                        {
                            return ModeSingle;
                        }
                    case "Birst":
                        {
                            return ModeBirst;
                        }
                    case "Auto":
                        {
                            return ModeAuto;
                        }
                    default:
                        {
                            return false;
                        }
                }
            }
            set
            {
                ModeSingle = ModeBirst = ModeAuto = false;
                switch (mode)
                {
                    case "Single":
                        {
                            ModeSingle = value;
                            break;
                        }
                    case "Birst":
                        {
                            ModeBirst = value;
                            break;
                        }
                    case "Auto":
                        {
                            ModeAuto = value;
                            break;
                        }
                }
            }
        }
        
        //----------------Конструкторы
        public Firearm(string model, string caliber, uint maxAmmo, uint ammoInClip)
        {
            Model = model;
            Caliber = caliber;
            MaxAmmo = maxAmmo;
            AmmoInClip = maxAmmo < ammoInClip ? maxAmmo : ammoInClip;
            IsReloaded = AmmoInClip != 0;
        }
        
        public Firearm()
        {
            Model = "M16";
            Caliber = "5,56";
            MaxAmmo = 30;
            AmmoInClip = 30;
            IsReloaded = true;
        }
        
        //----------------Методы
        public void ReloadFirearm(uint ammo)
        {
            AmmoInClip = ammo > MaxAmmo ? MaxAmmo : ammo;
            IsReloaded = true;
        }
        
        public void Shoot()
        {
            if (AmmoInClip > 0)
            {
                if (ModeSingle)
                {
                    AmmoInClip -= 1;
                    Console.WriteLine($"PAU! Ammo in clip: {AmmoInClip}/{MaxAmmo}");
                }
                if (ModeBirst)
                {
                    if (AmmoInClip > 2)
                    {
                        AmmoInClip -= 3;
                        Console.WriteLine($"PAU! PAU! PAU! Ammo in clip: {AmmoInClip}/{MaxAmmo}");
                    }
                    else if (AmmoInClip == 2)
                    {
                        AmmoInClip -= 2;
                        Console.WriteLine($"PAU! PAU! Ammo in clip: {AmmoInClip}/{MaxAmmo}");
                    }
                    else
                    {
                        AmmoInClip -= 1;
                        Console.WriteLine($"PAU! Ammo in clip: {AmmoInClip}/{MaxAmmo}");
                    }
                }
                if (ModeAuto)
                {
                    AmmoInClip -= 1;
                    Console.Write($"PAU! {AmmoInClip}/{MaxAmmo} ");
                }
            }
            else
            {
                IsReloaded = false;
            }
        }
        
        public static void GetGeneralInfo()
        {
            Console.WriteLine("A firearm is a gun designed to be readily carried and used by a single individual." +
                "\nModern firearms can be described by their caliber, model and by the type of action employed.");
        }
        
        public void GetInfo()
        {
            Console.WriteLine($"Model of your weapon: {Model}" +
                $"\nCaliber of your weapon: {Caliber}" +
                $"\nMax ammo in a clip: {MaxAmmo}" +
                $"\nCurrent ammo in a clip: {AmmoInClip}");
        }
        
        //----------------Деструктор
        ~Firearm() { }
    }
}
