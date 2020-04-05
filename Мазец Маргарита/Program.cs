using System;
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
    private double _step;
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
    public double Step
    {
        get
        {
            return _step;
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
    public People()
    {
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
}

namespace SiSharpLaba3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, surname, university, specialty, sort_university, name_seach;
            int birth_year, YesNo, max, counter = 0, menu;
            double middle_mark;
            bool result;
            do
            {
                Console.WriteLine("Какое максимальное количество студентов? ");
                result = int.TryParse(Console.ReadLine(), out max);
            } while (!result);
            People people = new People();
            for (int index = 0; index < max; index++)
            {
                counter++;
                Console.WriteLine("Введите имя:");
                name = Console.ReadLine();
                Console.WriteLine("Введите фамилию:");
                surname = Console.ReadLine();
                do
                {
                    Console.WriteLine("Введите год рождения:");
                    result = int.TryParse(Console.ReadLine(), out birth_year);
                } while (!result || (birth_year < 1900 || birth_year > 2020));
                Console.WriteLine("Введите университет:");
                university = Console.ReadLine();
                Console.WriteLine("Введите специальность:");
                specialty = Console.ReadLine();
                do
                {
                    Console.WriteLine("Введите средний балл:");
                    result = double.TryParse(Console.ReadLine(), out middle_mark);
                } while (!result || (middle_mark > 10.0 || middle_mark < 0.0));
                people[index] = new Person(name, surname, birth_year, university, specialty, middle_mark);
                do
                {
                    Console.WriteLine("Продолжить ввод? 1-да, 2-нет");
                    result = int.TryParse(Console.ReadLine(), out YesNo);
                } while (!result);
                if (YesNo == 2)
                    break;
            }
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1-вывести инфомацию");
                Console.WriteLine("2-вывести всех студентов одного учебного заведения");
                Console.WriteLine("3-вывести отдельного студента");
                Console.WriteLine("4-расчитать степендию студента");
                Console.WriteLine("5-расчитать среднюю степендию университета");
                Console.WriteLine("6-завершить программу");
                int.TryParse(Console.ReadLine(), out menu);
                switch (menu)
                {
                    case 1:
                        {
                            Console.Clear();
                            for (int index = 0; index < counter; index++)
                                people[index].WriteInformation();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("введите название учебного заведения:");
                            sort_university = Console.ReadLine();
                            for (int index = 0; index < counter; index++)
                                if (people[index].University == sort_university)
                                    people[index].ShowUniver();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("введите имя студента:");
                            name_seach = Console.ReadLine();
                            for (int index = 0; index < counter; index++)
                                if (people[index].Name == name_seach)
                                    people[index].WriteInformation();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("введите имя студента:");
                            name_seach = Console.ReadLine();
                            for (int index = 0; index < counter; index++)
                                if (people[index].Name == name_seach)
                                    people[index].Calculate_the_scholarship();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("введите название учебного заведения:");
                            sort_university = Console.ReadLine();
                            double sum = 0.0;
                            int count = 0;
                            for (int index = 0; index < counter; index++)
                            {
                                if (people[index].University == sort_university)
                                {
                                    sum = +people[index].Step;
                                    count++;
                                }
                            }
                            Console.WriteLine($"Средняя степендия:{sum / count}$");
                            break;
                        }
                    case 6: return;
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Введите число ещё раз:");
                            int.TryParse(Console.ReadLine(), out menu);
                            break;
                        }
                }
            }
        }
    }
}
