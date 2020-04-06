using System;
using System.Collections.Generic;
using System.Text;

namespace Chelovek
{
    class Human
    {
        //Структура
        private struct FIOS
        {
            public string name, surname, status;
        }

        //Поля
        private int age;
        private string _illness, _gender;
        private bool _ill, _isSleep;
        private FIOS fios;
        public static int birth_year;

        //Конструкторы
        public Human()
        {
            age = 2020 - birth_year;
            _ill = false;
            _isSleep = false;
        }

        public Human(string name, string surname, string status) : this()
        {
            fios.name = name;
            fios.surname = surname;
            fios.status = status;
        }

        public Human(string name, string surname, string status, string gender) : this(name, surname, status)
        {
            
            if (gender == "male" || gender == "female")
                _gender = gender;
        }

        //Свойства
        public string Name
        {
            get
            {
                return fios.name;
            }
            set
            {
                fios.name = value;
            }
        }

        public int Age
        {
            get
            {
                return 2020 - birth_year;
            }
        }

        public string Surname
        {
            get
            {
                return fios.surname;
            }
            set
            {
                fios.surname = value;
            }
        }

        public string Status
        {
            get
            {
                return fios.status;
            }
            set
            {
                fios.status = value;
            }
        }

        public bool isSleep
        {
            get
            {
                return _isSleep;
            }
        }

        public string Illness
        {
            get
            {
                if (_ill) return _illness;
                return $"{fios.name} is not ill";
            }
            set
            {
                _ill = true;
                _illness = value;
            }
        }

        //Индексатор
        public string this[string selection]
        {
            get
            {
                switch (selection)
                {
                    case "name": return fios.name;
                    case "surname": return fios.surname;
                    case "status": return fios.status;
                    default: return null;
                }
            }
            set
            {
                switch (selection)
                {
                    case "name": fios.name = value; break;
                    case "surname": fios.surname = value; break;
                    case "status": fios.status = value; break;
                }
            }
        }

        //Методы
        public void ShowInfo()
        {
            Console.WriteLine($"name - {fios.name}");
            Console.WriteLine($"surname - {fios.surname}");
            Console.WriteLine($"status - {fios.status}");
            Console.WriteLine($"gender - {_gender}");
            Console.WriteLine($"age - {age}");
            Console.WriteLine($"illness - {Illness}");
            if (_isSleep)
                Console.WriteLine($"Sleep status - sleeping (use Sleep to wake up)");
            else
                Console.WriteLine($"Sleep status - awakened");
        }

        public void Sleep()
        {
            _isSleep = true;
        }

        public void Awakening()
        {
            _isSleep = false;
        }

        public void ChangeGender()
        {
            _gender = (_gender == "male") ? "female" : "male";
        }

        public void Sing()
        {
            if (_isSleep || _ill)
                Console.WriteLine($"{fios.name} is not currently possible for singing. Create another object or awakening.");
            else
                Console.WriteLine($"{fios.name} sings : WHAT IS LOVE! BABY, DONT HURT ME, DONT HURT ME, NO MORE!");
            Console.ReadKey();
        }

        //Деструктор
        ~Human() { }
    }
}
