using System;
namespace SiSharpLaba3
{
    class Person
    {
        //----------------------------------------------поля
        private string _name, _surname;
        private static int _currentYear;
        private int _birthYear;
        private int _age;
        private string _university;
        private string _spesialty;
        private double _middleMark;
        private double _stependija;
        //-------------------------------конструкторы
        public Person()
        {
            _currentYear = 2020;
        }
        public Person(int birthYear)
        {
            _currentYear = 2020;
            _birthYear = birthYear;
            _age = _currentYear - birthYear;
        }
        public Person(string name, string surname, int birthYear)
        {
            _currentYear = 2020;
            _birthYear = birthYear;
            _age = _currentYear - birthYear;
            _name = name;
            _surname = surname;
        }
        public Person(string name, string surname, string university, string spesialty)
        {
            _currentYear = 2020;
            _name = name;
            _surname = surname;
            _university = university;
            _spesialty = spesialty;
        }
        public Person(string name, string surname, int birthYear, string university, string spesialty, double middleMark)
        {
            _currentYear = 2020;
            _birthYear = birthYear;
            _age = _currentYear - birthYear;
            _name = name;
            _surname = surname;
            _university = university;
            _spesialty = spesialty;
            _middleMark = middleMark;
        }
        //--------------------------------свойства
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string University
        {
            get
            {
                return _university;
            }
            set
            {
                _university = value;
            }
        }
        public double Stependija
        {
            get
            {
                return _stependija;
            }
        }
        public int Birth_year
        { get
            {
                return _birthYear;
            }
            set
            {
                if (Birth_year < 1900 || Birth_year > 2020)
                {
                    Console.WriteLine("Человека такого года рождения не существует!");
                }
                else
                {
                    _birthYear = value;
                    _age = _currentYear - Birth_year;
                }
            } 
        }
        public double Middle_mark
        {
            get
            {
                return _middleMark;
            }
            set
            {
                if (Middle_mark < 0 || Middle_mark > 10)
                    Console.WriteLine("Средний балл не может принимать такое значение!");               
                else
                {
                   _middleMark = value;
                }
            }
        }
        //-------------------------------------------методы
        public void WriteInformation()
    {
        Console.WriteLine($"Имя:{_name}");
        Console.WriteLine($"Фамилия:{_surname}");
        Console.WriteLine($"Возраст:{_age}");
        Console.WriteLine($"Университет:{_university}");
        Console.WriteLine($"Специальность:{_spesialty}");
        Console.WriteLine($"Средний балл:{_middleMark}\n");
    }
    public void ShowUniver()
    {
        Console.WriteLine($"{_name} учится на специальности\"{_spesialty}\"");
    }
    public void Scholarship()
    {
        if (_middleMark <= 4.0)
            _step = 0.0;
        if (_middleMark >= 4.0 && _middleMark <= 6.0)
            _step = 40.35;
        if (_middleMark >= 6.0 && _middleMark <= 8.0)
            _step = 62.29;
        if (_middleMark >= 8.0 && _middleMark <= 9.0)
            _step = 89.35;
        if (_middleMark >= 9.0 && _middleMark <= 10.0)
            _step = 100.0;
    }
    public void Calculate_the_scholarship()
    {
        Scholarship();
        Console.WriteLine($"{_name} получает степендию равную {_step}");
    }
}
    class People
    {
        public static int max;
        Person[] person;
        public int Counter { get; set; }
        public People(int Max)
        {
            max = Max;
            person = new Person[max];
        }
        public Person this[int index]
        {
            get
            {
                return person[index];
            }
            set
            {
                person[index] = value;
            }
        }
        public void ShowInformationAll()
        {
            Console.Clear();
            for (int index = 0; index < Counter; index++)
                person[index].WriteInformation();
        }
        public void ShowInformationOne()
        {
            Console.Clear();
            Console.WriteLine("введите имя студента:");
            string name_seach = Console.ReadLine();
            for (int index = 0; index < Counter; index++)
                if (person[index].Name == name_seach)
                    person[index].WriteInformation();
        }
        public void Student_Information_for_one_university()
        {
            Console.Clear();
            Console.WriteLine("введите название учебного заведения:");
            string sort_university = Console.ReadLine();
            for (int index = 0; index < Counter; index++)
                if (person[index].University == sort_university)
                    person[index].ShowUniver();
        }
        public void Calculate_the_scholarship_of_one_student()
        {
            Console.Clear();
            Console.WriteLine("введите имя студента:");
            string name_seach = Console.ReadLine();
            for (int index = 0; index < Counter; index++)
                if (person[index].Name == name_seach)
                    person[index].Calculate_the_scholarship();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string name, surname, university, specialty;
            int YesNo, max, counter = 0, menu;
            Console.WriteLine("Какое максимальное количество студентов? ");
            max = Convert.ToInt32(Console.ReadLine());
            People person = new People(max);
            for (int index = 0; index < max; index++)
            {
                counter++;
                Console.WriteLine("Введите имя:");
                name = Console.ReadLine();
                Console.WriteLine("Введите фамилию:");
                surname = Console.ReadLine();
                Console.WriteLine("Введите университет:");
                university = Console.ReadLine();
                Console.WriteLine("Введите специальность:");
                specialty = Console.ReadLine();
                person[index] = new Person(name, surname, university, specialty);
                Console.WriteLine("Введите год рождения:");
                person[index].Birth_year= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите средний балл:");
                person[index].Middle_mark = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Продолжить ввод? 1-да, 2-нет");
                YesNo=Convert.ToInt32(Console.ReadLine());
                if (YesNo == 2)
                    break;
            }
            person.Counter = counter;
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1-вывести инфомацию");
                Console.WriteLine("2-вывести всех студентов одного учебного заведения");
                Console.WriteLine("3-вывести отдельного студента");
                Console.WriteLine("4-расчитать степендию студента");
                Console.WriteLine("5-завершить программу");
                menu=Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        {
                            person.ShowInformationAll();
                            break;
                        }
                    case 2:
                        {
                            person.Student_Information_for_one_university();
                            break;
                        }
                    case 3:
                        {
                            person.ShowInformationOne();
                            break;
                        }
                    case 4:
                        {
                            person.Calculate_the_scholarship_of_one_student();
                            break;
                        }
                    case 5: return;
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Введите число ещё раз:");
                            menu=Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                }
            }
        }
    }
}
