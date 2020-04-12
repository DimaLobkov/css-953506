using System;
using System.Collections.Generic;
using System.Text;

namespace Laba3
{
    class Human
    {
        public string name;
        public string surname;
        public int age;
        public string status = "student";
        public int math = 0, rus = 0, phys = 0;
        public double srb = 0.0;

        public string GetName()
        {
            Console.WriteLine($"Имя: ");
            name = Console.ReadLine();
            return name;
        }

        public string GetSurname()
        {
            Console.WriteLine($"Фамилия: ");
            surname = Console.ReadLine();
            return surname;
        }

        public int GetAge()
        {
            Console.WriteLine($"Возраст: ");
            int.TryParse(Console.ReadLine(), out age);
            return age;
        }

        public int GetMath()
        {
            Console.WriteLine($"Математика: ");
            int.TryParse(Console.ReadLine(), out math);
            return math;

        }

        public int GetRus()
        {
            Console.WriteLine($"Русский: ");
            int.TryParse(Console.ReadLine(), out rus);
            return rus;
        }

        public int GetPhys()
        {
            Console.WriteLine($"Физика: ");
            int.TryParse(Console.ReadLine(), out phys);
            return phys;
        }

        public double GetSrb()
        {
            srb = (math + rus + phys) / 3.0;
            Console.WriteLine($"\nОбщий средний балл: {srb}");
            return srb;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Имя:{name}\nФамилия:{surname}\nВозраст:{age} Статус:{status}\n");
            Console.WriteLine($"Средние баллы:\nМатем:{math}  Рус:{rus}  Физика:{phys}\nОбщий ср.балл:{srb}\n");
        }

        public void GetIzmena()
        {
            char predmet;
            int izmena = 0;
            Console.WriteLine($"Выберите предмет\nМатематика-1  Русский-2  Физика-3");
            predmet = Console.ReadKey().KeyChar;
            Console.WriteLine($"На сколько изменить отметку   пример(2 / -4)");
            int.TryParse(Console.ReadLine(), out izmena);
            if (predmet == '1')
            {
                if (math + izmena > 10)
                {
                    Console.WriteLine($"Ошибка, повторите ввод снова");
                }
                else
                {
                    math += izmena;
                }
            }
            if (predmet == '2')
            {
                if (rus + izmena > 10)
                {
                    Console.WriteLine($"Ошибка, повторите ввод снова");
                }
                else
                {
                    rus += izmena;
                }
            }
            if (predmet == '3')
            {
                if (phys + izmena > 10)
                {
                    Console.WriteLine($"Ошибка, повторите ввод снова");
                }
                else
                {
                    phys += izmena;
                }
            }
        }

        public void GetOtchislenie()
        {
            status = "otchislen";
            math = 0;
            rus = 0;
            phys = 0;
            srb = 0;
        }
    }
    class Gruppa : Human
    {
        Human[] data;
        public Gruppa(int kolv)
        {
            data = new Human[kolv + 1];
        }
        public Human this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
    }
}
