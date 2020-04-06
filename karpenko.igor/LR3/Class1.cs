using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    class Gun
    {
        private int _magazin = 6;
        private int _magazinNow;
        private string _name = "пистолет";
        private string _cname = "Пистолет";
        private int _iznos;
        private bool _zaryad;
        private bool _pricel;
        private bool _fuse;
        private bool _sobran;
        private static int _score;
        public Gun()
        {
            _magazinNow = 0;
            _iznos = 0;
            _zaryad = false;
            _pricel = false;
            _fuse = true;
            _sobran = true;
        }

        public Gun(int n)
        {
            _iznos = 0;
            _zaryad = false;
            _pricel = false;
            _fuse = true;
            _sobran = true;

            if (n > 6)
            {
                Console.WriteLine($"Слишком много патронов, в магазин влезет только {_magazin}");
                _magazinNow = _magazin;

            }
            else if (n < 0)
            {
                Console.WriteLine("Что-то не то, магазин будет пустым");
                _magazinNow = 0;

            }
            else
            {
                _magazinNow = n;
                Console.WriteLine($"{_cname} заряжен");
            }
        }

        public int Score
        {
            get
            {
                return _score;
            }

            set
            {
                _score = value;
            }
        }

        public void Zaryad()
        {
            if (!_sobran)
            {
                Console.WriteLine($"{_cname} разобран!");
                return;
            }
            _pricel = false;
            if (_magazinNow == 0)
            {
                Console.WriteLine("В магазине нет патронов");
            }
            else if (_zaryad) Console.WriteLine($"Вы уже зарядили {_name}");
            else
            {
                _zaryad = true;
                Console.WriteLine($"{_cname} заряжен!");
            }
        }

        public void Remont()
        {
            if (!_sobran)
            {
                Console.WriteLine($"{_cname} разобран!");
                return;
            }
            _pricel = false;
            if (_iznos < 60)
            {
                Console.WriteLine($"Износ еще приемемый, {_name} можно починить только с 60% износа");
            }
            else
            {
                _iznos = 0;
                Console.WriteLine($"Ваш {_name} успешно отремонтирован");
            }
        }

        public void Fuse()
        {
            if (!_sobran)
            {
                Console.WriteLine($"{_cname} разобран!");
                return;
            }
            _pricel = false;
            if (_fuse)
            {
                _fuse = false;
                Console.WriteLine($"{_cname} снят с предоханителя!");
            }
            else
            {
                _fuse = true;
                Console.WriteLine($"{_cname} поставлен на предохранитель!");
            }
        }

        public void Perezaryad()
        {
            if (!_sobran)
            {
                Console.WriteLine($"{_cname} разобран!");
                return;
            }
            _pricel = false;
            if (_magazinNow == _magazin) Console.WriteLine("Магазин и так уже полон");
            else
            {
                _magazinNow = _magazin;
                Console.WriteLine("Обойма вновь полна патронами!");
            }
        }

        public void Shot()
        {
            if (!_sobran)
            {
                Console.WriteLine($"{_cname} разобран!");
                return;
            }
            Random rnd = new Random();

            if (_zaryad == false)
            {
                Console.WriteLine($"Для начала {_name} нужно зарядить!");
                return;
            }
            if (_fuse == true)
            {
                Console.WriteLine("Снимите с предохранителя!");
                return;
            }
            if (_iznos > 95)
            {
                Console.WriteLine($"{_cname} поломан и не может стрелять");
                return;
            }

            Console.Write("БАНГ! ");
            int mishen = 0;

            if (_pricel == true)
            {
                if (_iznos < 15)
                {
                    mishen = rnd.Next(8, 11);
                }
                else if (_iznos < 30)
                {
                    mishen = rnd.Next(7, 9);
                }
                else if (_iznos < 50)
                {
                    mishen = rnd.Next(5, 8);
                }
                else if (_iznos < 70)
                {
                    mishen = rnd.Next(4, 7);
                }
                else if (_iznos < 85)
                {
                    mishen = rnd.Next(3, 5);
                }
                else
                {
                    mishen = rnd.Next(0, 3);
                }

            }
            else
            {
                if (_iznos < 15)
                {
                    mishen = rnd.Next(7, 9);
                }
                else if (_iznos < 30)
                {
                    mishen = rnd.Next(5, 8);
                }
                else if (_iznos < 50)
                {
                    mishen = rnd.Next(3, 6);
                }
                else if (_iznos < 70)
                {
                    mishen = rnd.Next(1, 5);
                }
                else if (_iznos < 85)
                {
                    mishen = rnd.Next(0, 2);
                }
                else
                {
                    mishen = 0;
                }
            }

            Result(mishen);

            _score += mishen;
            _zaryad = false;
            _pricel = false;
            _iznos += rnd.Next(3, 6);
            _magazinNow--;
        }

        private void Result(int m)
        {
            if (m == 10) Console.WriteLine("Отличный выстрел, в самое яблочко(10)!");
            else if (m > 6 && m < 10) Console.WriteLine($"Хороший выстел, попали в {m}");
            else if (m > 3 && m < 7) Console.WriteLine($"Неплохо, попали в {m}");
            else if (m > 0 && m < 4) Console.WriteLine($"Можно было и лучше, попали в {m}");
            else if (m == 0) Console.WriteLine($"В молоко!");

        }

        public void Pricel()
        {
            if (!_sobran)
            {
                Console.WriteLine($"{_cname} разобран!");
                return;
            }
            _pricel = true;
            Console.WriteLine($"Вы навели {_name} на мишень...");
        }

        public void Razbor()
        {
            if (_sobran)
            {
                if (_zaryad)
                {
                    Console.WriteLine($"{_cname} заряжен, разбирать запрещено!");
                    return;
                }

                Console.WriteLine("Нажимаем кнопку защёлки магазина и извлекаем его из рукоятки");
                Console.WriteLine("Опустив флажок выключаем предохранитель");
                _fuse = false;
                Console.WriteLine("Оттягиваем спусковую скобу вниз и, перекосив её в сторону, упераем в рамку");
                Console.WriteLine("Отводим затвор в крайнее заднее положение и, приподняв его заднюю часть, движением вперёд отделяем от рамки");
                Console.WriteLine("Возвращаем на место спусковую скобу");
                Console.WriteLine("Снимаем со ствола возвратную пружину");
                Console.WriteLine($"{_cname} разобран!");
                _sobran = false;
            }
            else
            {
                Console.WriteLine("Надеваем на ствол возвратную пружину");
                Console.WriteLine("Снимаем спусковую скобу");
                Console.WriteLine("Присоединяем затвор к рамке");
                Console.WriteLine("Оттягиваем спусковую скобу вниз и, перекосив её в сторону, упераем в рамку");
                Console.WriteLine("Включаем предохранитель");
                _fuse = true;
                Console.WriteLine("Нажимаем кнопку защёлки магазина и вставляем его в рукоятку");
                Console.WriteLine($"{_cname} собран!");
                _sobran = true;
            }
        }

        public void Charac()
        {
            Console.WriteLine($"Перед каждым выстрелом {_name} нужно заряжать");
            Console.WriteLine("При большом износе точность снижается");
            Console.WriteLine("На предохранителе пистолет не стреляет");
            Console.WriteLine("Прицеливание увеличивает точность");
            Console.WriteLine("Прицеливание каждый раз сбивается, когда вы выбираете другое действие");
        }

        public void Menu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("f - Зарядить");
            Console.WriteLine("r - Ремонт");
            Console.WriteLine("t - Предохранитель");
            Console.WriteLine("g - Пополнить магазин");
            Console.WriteLine("h - Прицелиться");
            Console.WriteLine("y - Выстрел");
            if (_sobran) Console.WriteLine("k - Разборка оружия");
            else Console.WriteLine("k - Сборка оружия");
            Console.WriteLine("j - Информация об оружии");
        }

        public void Info()
        {
            Console.WriteLine();
            Console.WriteLine($"Оружие:{_name}\t\tПатронов в магазине:{_magazinNow}\t\tИзнос:{_iznos}%");
        }

        ~Gun() { }
    }
}
