using System;
using static System.Console;
using System.Windows.Forms;

class Human
{
    private static int Number = 1843650;
    private string[] parent = new string [2];
    
    public Human()
    {
        ID = Number + 1;
        ++Number;
        Name = "";
        Age = 0;
        High = 0;
        Weight = 0;
        Birthdate = new DateTime(1900, 1, 1);
    }

    public Human(string name, int age, int high, float weight, DateTime birthdate,string parent0,string parent1)
    {
        ID = Number + 1;
        ++Number;
        Name = name;
        Age = age;
        High = high;
        Weight = weight;
        Birthdate = birthdate;
        parent[0] = parent0;
        parent[1] = parent1;
    }

    public int ID { get; }
    
    public string Name
    { get; set;}
    
    public int Age
    { get; set; }
    
    public int High
    { get; set; }
    
    public float Weight
    { get; set; }
    
    public DateTime Birthdate
    { get; set; }

    public string this[int index]
    {
        get => parent[index];
        set => parent[index] = value;
    }

    public void cout()
    {
        WriteLine(Name);
        WriteLine(Age);
        WriteLine(High); 
        WriteLine(Weight);
        WriteLine(Birthdate);
        WriteLine(parent[0]);
        WriteLine(parent[1]);
    }

    public void date()
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
        catch(FormatException e)
        {
            MessageBox.Show(e.Message);
        }
    }

    ~Human() { }
}

class Program
{
    static Human Creat()
    {
        try
        {
            WriteLine("Введите имя");
            string name = ReadLine();
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
            DateTime birthdate = new DateTime(year, month, day);
            WriteLine("Введите имя папы");
            string parent0 = ReadLine();
            WriteLine("Введите имя мамы");
            string parent1 = ReadLine();
            if (age < 1 || high < 0 || weight < 0)
                throw new Exception("Данные неверно введены (присутствуют отрицательные или невозможные числа) ");
            Human you = new Human(name, age, high, weight, birthdate, parent0, parent1);
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
    static void Main(string[] args)
    {
        ConsoleKeyInfo key;
        WriteLine("Хотите сначала ввести данные? 1 - да,0 - нет");
        bool b = true;
        Human you = new Human() ;
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
                       you = Creat();
                        b = false;
                        break;
            }
        }
        b = true;
        while (b == true)
        {
            Clear();
            b = true;
            WriteLine("0 - завершить работу, 1 - вывести класс, 2 - вывести построчно, 3 - изменить построчно");
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
                        WriteLine("Вывод:\n 0 - выход,\n 1 - имя,\n 2 - возраст,\n 3 - рост,\n 4 - вес,\n 5 - день рождения,\n 6 - родители,\n 7 - ID");
                        while (b == true)
                        {
                            key = ReadKey(true);
                            switch (key.Key)
                            {
                                case ConsoleKey.D0: b = false; break;
                                case ConsoleKey.D1: WriteLine(you.Name);  break; 
                                case ConsoleKey.D2: WriteLine(you.Age);  break; 
                                case ConsoleKey.D3: WriteLine(you.High); break; 
                                case ConsoleKey.D4: WriteLine(you.Weight);  break; 
                                case ConsoleKey.D5: WriteLine("{0:D}",you.Birthdate);  break; 
                                case ConsoleKey.D6: WriteLine(you[0] + ' ' + you[1]);  break; 
                                case ConsoleKey.D7: WriteLine(you.ID);  break; 

                            }
                        }
                        b = true;
                        break;
                case ConsoleKey.D3:
                        b = true;
                        WriteLine("Изменение:\n 0 - выход,\n 1 - имя,\n 2 - возраст,\n 3 - рост,\n 4 - вес,\n 5 - день рождения,\n 6 - имя папы,\n 7 - имя мамы");
                        while (b == true)
                        {
                            key = ReadKey(true);
                            switch (key.Key)
                            {
                                case ConsoleKey.D0: b = false; break;
                                case ConsoleKey.D1: Write("Введите имя "); you.Name = ReadLine(); break;
                                case ConsoleKey.D2: Write("Введите возраст "); you.Age = int.Parse(ReadLine()); break;
                                case ConsoleKey.D3: Write("Введите рост "); you.High = int.Parse(ReadLine()); break;
                                case ConsoleKey.D4: Write("Введите вес "); you.Weight = int.Parse(ReadLine()); break;
                                case ConsoleKey.D5: Write("Введите дату "); you.date(); break;
                                case ConsoleKey.D6: Write("Введите имя папы "); you[0] = ReadLine(); break;
                                case ConsoleKey.D7: Write("Введите имя мамы "); you[1] = ReadLine(); break;

                            }
                        }
                        b = true;
                        break;
            }
         }
    }
 }
