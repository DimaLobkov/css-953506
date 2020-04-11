using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Firearm
    {
        private string _model;
        private string _caliber;
        private uint _maxAmmo;
        private uint _ammoInClip;
        private bool _reload;
        private bool _safety = true;
        private static string _generalInfo = "Firearm weapon use ammo to shoot";
        private bool[] _mode = new bool[3] { true, false, false };
        
        public bool Reload
        {
            get
            {
                return _reload;
            }
            set
            {
                _ammoInClip = _maxAmmo;
                _reload = value;
            }
        }
        
        public bool Safety
        {
            get
            {
                return _safety;
            }
            set
            {
                _safety = value;
            }
        }
        
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        
        public string Caliber
        {
            get
            {
                return _caliber;
            }
            set
            {
                _caliber = value;
            }
        }
        
        public uint MaxAmmo
        {
            get
            {
                return _maxAmmo;
            }
            set
            {
                _maxAmmo = value;
            }
        }
        
        public uint AmmoInClip
        {
            get
            {
                return _ammoInClip;
            }
            set
            {
                _ammoInClip = value;
                _reload = _ammoInClip == 0;
            }
        }
        
        public bool this[int index]
        {
            get
            {
                return _mode[index];
            }
            set
            {
                _mode[0] = _mode[1] = _mode[2] = false;
                _mode[index] = value;
            }
        }
        
        public Firearm(string model, string caliber, uint maxAmmo, uint ammoInClip)
        {
            _model = model;
            _caliber = caliber;
            _maxAmmo = maxAmmo;
            _ammoInClip = maxAmmo < ammoInClip ? maxAmmo : ammoInClip;
        }
        
        public Firearm()
        {
            _model = "M16";
            _caliber = "5,56";
            _maxAmmo = 30;
            _ammoInClip = 30;
        }
        
        public void ReloadFirearm(uint ammo)
        {
            _ammoInClip = ammo > _maxAmmo ? _maxAmmo : ammo;
            _reload = false;
        }
        
        public void Shoot()
        {
            if (_ammoInClip > 0)
            {
                if (_mode[0])
                {
                    _ammoInClip -= 1;
                    Console.WriteLine($"PAU! Ammo in clip: {_ammoInClip}/{_maxAmmo}");
                }
                if(_mode[1])
                {
                    if(_ammoInClip > 2)
                    {
                        _ammoInClip -= 3;
                        Console.WriteLine($"PAU! PAU! PAU! Ammo in clip: {_ammoInClip}/{_maxAmmo}");
                    }
                    else if(_ammoInClip == 2)
                    {
                        _ammoInClip -= 2;
                        Console.WriteLine($"PAU! PAU! Ammo in clip: {_ammoInClip}/{_maxAmmo}");
                    }
                    else if(_ammoInClip == 1)
                    {
                        _ammoInClip -= 1;
                        Console.WriteLine($"PAU! Ammo in clip: {_ammoInClip}/{_maxAmmo}");
                    }
                }
                if(_mode[2])
                {
                    _ammoInClip -= 1;
                    Console.Write($"PAU! {_ammoInClip}/{_maxAmmo} ");
                }
            }
            else
            {
                _reload = true;
            }    
        }
        
        public void GetInfo()
        {
            Console.WriteLine($"{_generalInfo}" +
                $"\nModel of your weapon: {_model}" +
                $"\nCaliber of your weapon: {_caliber}" +
                $"\nMax ammo in a clip: {_maxAmmo}" +
                $"\nCurrent ammo in a clip: {_ammoInClip}");
        }
    }
}
