using System;
using static System.Console;
using System.Windows.Forms;

class Human
{
    private static int _number = 1843650;
    private string[] _parent = new string[2];

    public Human()
    {
        ID = _number + 1;
        ++_number;
        Name = "Name";
        SurName = "Surname";
        Age = 1;
        High = 1;
        Weight = 1;
        Nationality = "English";
        Birthdate = new DateTime(1900, 1, 1);
    }

    public Human(string name, string surname, int age, int high, float weight, string nationality, DateTime birthdate, string parent0, string parent1)
    {
        ID = _number + 1;
        ++_number;
        Name = name;
        SurName = surname;
        Age = age;
        High = high;
        Weight = weight;
        Nationality = nationality;
        Birthdate = birthdate;
        _parent[0] = parent0;
        _parent[1] = parent1;
    }

    public int ID { get; }
    public string Name { get; set; }
    public string SurName { get; set; }
    public int Age { get; set; }
    public int High { get; set; }
    public float Weight { get; set; }
    public string Nationality { get; set; }
    public DateTime Birthdate { get; set; }
    public float IMT { get => Weight * 100 / High * 100 / High ; }

    public string this[int index]
    {
        get => _parent[index];
        set => _parent[index] = value;
    }

    public void cout()
    {
        WriteLine(Name);
        WriteLine(SurName);
        WriteLine(Age);
        WriteLine(High);
        WriteLine(Weight);
        WriteLine(Nationality);
        WriteLine(Birthdate);
        WriteLine(_parent[0]);
        WriteLine(_parent[1]);
    }
    public int CalculateAge(int year = 0)
    {
        if (year == 0)
            return DateTime.Now.Year-Birthdate.Year;
        else if (year< Birthdate.Year)
            return year- Birthdate.Year;
        return 0;
    }

    public void ImportantDates()
    {
        WriteLine("{1} {0}, {2}, {3} лет (ID {4})",Name,SurName,Nationality,Age,ID);
    }

    public void Date()
    {
        try
        {
            Write("Введите день рождения(день)");
            int day = int.Parse(ReadLine());
            Write("Введите день рождения(месяц)");
            int month = int.Parse(ReadLine());
            Write("Введите день рождения(год)");
            int year = int.Parse(ReadLine());
            DateTime z = new DateTime(year, month, day);
            Birthdate = z;
        }
        catch (FormatException e)
        {
            MessageBox.Show(e.Message);
            Clear();
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
            Clear();
        }
    }

    public static Human Creat()
    {
        try
        {
            WriteLine("Введите имя");
            string name = ReadLine();
            WriteLine("Введите фамилию");
            string surname = ReadLine();
            WriteLine("Введите возраст");
            int age = int.Parse(ReadLine());
            WriteLine("Введите рост(см)");
            int high = int.Parse(ReadLine());
            WriteLine("Введите массу(кг)");
            int weight = int.Parse(ReadLine());
            WriteLine("Введите день рождения(день)");
            int day = int.Parse(ReadLine());
            WriteLine("Введите день рождения(месяц)");
            int month = int.Parse(ReadLine());
            WriteLine("Введите день рождения(год)");
            int year = int.Parse(ReadLine());
            WriteLine("Введите национальность");
            string nationality = ReadLine();
            DateTime birthdate = new DateTime(year, month, day);
            WriteLine("Введите имя папы");
            string parent0 = ReadLine();
            WriteLine("Введите имя мамы");
            string parent1 = ReadLine();
            if (age < 1 || high < 1 || weight < 1)
                throw new Exception("Данные неверно введены (присутствуют отрицательные или невозможные числа) ");
            Human you = new Human(name, surname, age, high, weight, nationality, birthdate, parent0, parent1);
            return you;
        }
        catch (FormatException e)
        {
            MessageBox.Show(e.Message);
            Creat();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            Creat();
        }
        return null;
    }

    ~Human() { }
}

class Program
{
    static void Main(string[] args)
    {
        ConsoleKeyInfo key;
        WriteLine("Хотите сначала ввести данные? 1 - да,0 - нет");
        bool b = true;
        Human you = new Human();
        while (b == true)
        {
            key = ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.D0:
                    you = new Human();
                    b = false;
                    break;
                case ConsoleKey.D1:
                    you = Human.Creat();
                    b = false;
                    break;
            }
        }
        b = true;
        while (b == true)
        {
            Clear();
            b = true;
            WriteLine("0 - завершить работу, 1 - вывести класс, 2 - вывести построчно, 3 - изменить построчно, 4 - индекс массы тела,\n 5 - важная информация");
            key = ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.D0:
                    b = false;
                    break;
                case ConsoleKey.D1:
                    you.cout();
                    Write("Введите любую клавишу, чтобы выйти...");
                    ReadKey(true);
                    break;
                case ConsoleKey.D2:
                    b = true;
                    WriteLine("Вывод:\n 0 - выход,\n 1 - имя,\n 2 - фамилия,\n 3 - возраст,\n 4 - рост,\n 5 - вес,\n 6 - национальность,\n 7 - день рождения,\n 8 - родители,\n 9 - ID");
                    while (b == true)
                    {
                        key = ReadKey(true);
                        switch (key.Key)
                        {
                            case ConsoleKey.D0: b = false; break;
                            case ConsoleKey.D1: WriteLine(you.Name); break;
                            case ConsoleKey.D2: WriteLine(you.SurName); break;
                            case ConsoleKey.D3: WriteLine(you.Age); break;
                            case ConsoleKey.D4: WriteLine(you.High); break;
                            case ConsoleKey.D5: WriteLine(you.Weight); break;
                            case ConsoleKey.D6: WriteLine(you.Nationality); break;
                            case ConsoleKey.D7: WriteLine("{0:D}", you.Birthdate); break;
                            case ConsoleKey.D8: WriteLine(you[0] + ' ' + you[1]); break;
                            case ConsoleKey.D9: WriteLine(you.ID); break;

                        }
                    }
                    b = true;
                    break;
                case ConsoleKey.D3:
                    b = true;
                    WriteLine("Изменение:\n 0 - выход,\n 1 - имя,\n 2 - фамилия,\n 3 - возраст,\n 4 - рост,\n 5 - вес,\n 6 - национальность,\n 7 - день рождения,\n 8 - родители,\n 9 - ID");
                    while (b == true)
                    {
                        key = ReadKey(true);
                        switch (key.Key)
                        {
                            case ConsoleKey.D0: b = false; break;
                            case ConsoleKey.D1: Write("Введите имя "); you.Name = ReadLine(); break;
                            case ConsoleKey.D2: Write("Введите фамилию "); you.SurName = ReadLine(); break;
                            case ConsoleKey.D3: Write("Введите возраст "); you.Age = int.Parse(ReadLine()); break;
                            case ConsoleKey.D4: Write("Введите рост "); you.High = int.Parse(ReadLine()); break;
                            case ConsoleKey.D5: Write("Введите вес "); you.Weight = int.Parse(ReadLine()); break;
                            case ConsoleKey.D6: Write("Введите национальность "); you.Nationality = ReadLine(); break;
                            case ConsoleKey.D7: Write("Введите дату "); you.Date(); break;
                            case ConsoleKey.D8: Write("Введите имя папы "); you[0] = ReadLine(); break;
                            case ConsoleKey.D9: Write("Введите имя мамы "); you[1] = ReadLine(); break;

                        }
                    }
                    b = true;
                    break;
                case ConsoleKey.D4:
                    WriteLine("Индекс массы тела = {0}\n", you.IMT);
                    key = ReadKey(true);
                    break;
                case ConsoleKey.D5:
                    you.ImportantDates();
                    key = ReadKey(true);
                    break;
            }
        }
    }
}
