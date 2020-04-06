using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Firearm
    {
        private string model;
        private string caliber;
        private uint maxAmmo;
        private uint ammoInClip;
        private bool reload;
        private static string generalInfo = "Firearm weapon use ammo to shoot";
        public static string GeneralInfo
        {
            get
            {
                return generalInfo;
            }
        }
        public bool Reload
        {
            get
            {
                return reload;
            }
            set
            {
                ammoInClip = maxAmmo;
                reload = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public string Caliber
        {
            get
            {
                return caliber;
            }
            set
            {
                caliber = value;
            }
        }
        public uint MaxAmmo
        {
            get
            {
                return maxAmmo;
            }
            set
            {
                maxAmmo = value;
            }
        }
        public uint AmmoInClip
        {
            get
            {
                return ammoInClip;
            }
            set
            {
                ammoInClip = value;
                reload = ammoInClip == 0;
            }
        }
        public Firearm()
        {
            model = "M16";
            caliber = "5,56";
            maxAmmo = 30;
            ammoInClip = 30;
        }
        public void ReloadFirearm(uint ammo)
        {
            if (ammo > maxAmmo)
            {
                ammoInClip = maxAmmo;
            }
            else
            {
                ammoInClip = ammo;
            }
            reload = false;
        }
        public void Shoot()
        {
            if (ammoInClip > 0)
            {
                ammoInClip -= 1;
                Console.WriteLine($"PAU! Ammo in clip: {ammoInClip}/{maxAmmo}");
            }
            else
            {
                reload = true;
            }
        }
    }
}
