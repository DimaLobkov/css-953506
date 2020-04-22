using System;

namespace lab5
{
    public struct Provero4ka
    {
        private int _age;
        private int _height;
        private int _weight;
        private string _gender;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value == 0 || value > 120)
                {
                    Console.WriteLine("Такого человека не существует");
                    Environment.Exit(-1);
                }
                else
                {
                    _age = value;
                }
            }
        }

        public int Height
        {
            get { return _height; }
            set
            {
                if (value <= 20 || value > 250)
                {
                    Console.WriteLine("Такого человека не существует");
                    Environment.Exit(-1);
                }
                else
                {
                    _height = value;
                }
            }
        }

        public int Weight
        {
            get { return _weight; }
            set
            {
                if (value <= 0 || value > 250)
                {
                    Console.WriteLine("Такого человека не существует");
                    Environment.Exit(-1);
                }
                else
                {
                    _weight = value;
                }
            }
        }

        public string Gender
        {
            get { return _gender; }
            set
            {
                if (value == "м" || value == "ж" || value == "m" || value == "f")
                {
                    _gender = value;
                }
                else
                {
                    Console.WriteLine("Такого человека не существует, т.к существует только два гендера");
                    Environment.Exit(-1);
                }
            }
        }
    }

    abstract class Person
    {
        public Provero4ka provero4ka;
        public string _name, _surname;
        public abstract void Сaloric(int height, int weight, string gender, int age);
        public abstract void Water(int weight, string gender);
        public abstract void IMT(int weight, double height);   
    }

    class Disabled : Person
    {
        public Disabled(string name, string surname, int age, int height, int weight, string gender)
        {
            _name = name;
            _surname = surname;
            provero4ka.Age = age;
            provero4ka.Height = height;
            provero4ka.Weight = weight;
            provero4ka.Gender = gender;
        }

        public override void Сaloric(int height, int weight, string gender, int age)
        {
            if (gender == "м" || gender == "m")
            {
                double norma = 88.36 + 13.4 * weight + 4.8 * height - 5.7 * age;
                Console.WriteLine(norma);
            }
            else if (gender == "ж" || gender == "f")
            {
                double norma = 447.6 + 9.2 * weight + 3.1 * height - 4.3 * age;
                Console.WriteLine(norma);
            }
        }

        public override void Water(int weight, string gender)
        {
            if (gender == "м" || gender == "m")
            {
                double norma = 40 * weight;
                Console.WriteLine(norma);
            }
            else if (gender == "ж" || gender == "f")
            {
                double norma = 30 * weight;
                Console.WriteLine(norma);
            }
        }

        public override void IMT(int weight, double height)
        {
            double index;
            index = weight / ((height / 100) * (height / 100));
            if (index < 16)
            {
                Console.WriteLine("Ярко выраженный дефицит массы тела");
            }
            else if (index > 16 && index < 18.5)
            {
                Console.WriteLine("Дефицит массы тела");
            }
            else if (index > 18.5 && index < 25)
            {
                Console.WriteLine("Норма");
            }
            else if (index > 25 && index < 30)
            {
                Console.WriteLine("Предожирение");
            }
            else if (index > 30 && index < 35)
            {
                Console.WriteLine("Ожирение первой степени");
            }
            else if (index > 35 && index < 40)
            {
                Console.WriteLine("Ожирение второй степени");
            }
            else if (index > 40)
            {
                Console.WriteLine("Ожирение третьей степени");
            }
        }
    }

    class Sedentary : Person
    {
        public Sedentary(string name, string surname, int age, int height, int weight, string gender)
        {
            _name = name;
            _surname = surname;
            provero4ka.Age = age;
            provero4ka.Height = height;
            provero4ka.Weight = weight;
            provero4ka.Gender = gender;
        }

        public override void Сaloric(int height, int weight, string gender, int age)
        {
            if (gender == "м" || gender == "m")
            {
                double norma = (88.36 + 13.4 * weight + 4.8 * height - 5.7 * age) * 1.2;
                Console.WriteLine(norma);

            }
            else if (gender == "ж" || gender == "f")
            {
                double norma = (447.6 + 9.2 * weight + 3.1 * height - 4.3 * age) * 1.2;
                Console.WriteLine(norma);
            }
        }

        public override void Water(int weight, string gender)
        {
            if (gender == "м" || gender == "m")
            {
                double norma = 40 * weight;
                Console.WriteLine(norma);
            }
            else if (gender == "ж" || gender == "f")
            {
                double norma = 30 * weight;
                Console.WriteLine(norma);
            }
        }

        public override void IMT(int weight, double height)
        {
            double index;
            index = weight / ((height / 100) * (height / 100));
            if (index < 16)
            {
                Console.WriteLine("Ярко выраженный дефицит массы тела");
            }
            else if (index > 16 && index < 18.5)
            {
                Console.WriteLine("Дефицит массы тела");
            }
            else if (index > 18.5 && index < 25)
            {
                Console.WriteLine("Норма");
            }
            else if (index > 25 && index < 30)
            {
                Console.WriteLine("Предожирение");
            }
            else if (index > 30 && index < 35)
            {
                Console.WriteLine("Ожирение первой степени");
            }
            else if (index > 35 && index < 40)
            {
                Console.WriteLine("Ожирение второй степени");
            }
            else if (index > 40)
            {
                Console.WriteLine("Ожирение третьей степени");
            }
        }
    }

    class Healthy : Person
    {
        public Healthy(string name, string surname, int age, int height, int weight, string gender)
        {
            _name = name;
            _surname = surname;
            provero4ka.Age = age;
            provero4ka.Height = height;
            provero4ka.Weight = weight;
            provero4ka.Gender = gender;
        }

        public override void Сaloric(int height, int weight, string gender, int age)
        {
            if (gender == "м" || gender == "m")
            {
                double norma = (88.36 + 13.4 * weight + 4.8 * height - 5.7 * age) * 1.5;
                Console.WriteLine(norma);
            }
            else if (gender == "ж" || gender == "f")
            {
                double norma = (447.6 + 9.2 * weight + 3.1 * height - 4.3 * age) * 1.5;
                Console.WriteLine(norma);
            }
        }

        public override void Water(int weight, string gender)
        {
            if (gender == "м" || gender == "m")
            {
                double norma = 40 * weight + 400;
                Console.WriteLine(norma);
            }
            else if (gender == "ж" || gender == "f")
            {
                double norma = 30 * weight + 400;
                Console.WriteLine(norma);
            }
        }

        public override void IMT(int weight, double height)
        {
            double index;
            index = weight / ((height / 100) * (height / 100));
            if (index < 16)
            {
                Console.WriteLine("Ярко выраженный дефицит массы тела");
            }
            else if (index > 16 && index < 18.5)
            {
                Console.WriteLine("Дефицит массы тела");
            }
            else if (index > 18.5 && index < 25)
            {
                Console.WriteLine("Норма");
            }
            else if (index > 25 && index < 30)
            {
                Console.WriteLine("Предожирение");
            }
            else if (index > 30 && index < 35)
            {
                Console.WriteLine("Ожирение первой степени");
            }
            else if (index > 35 && index < 40)
            {
                Console.WriteLine("Ожирение второй степени");
            }
            else if (index > 40)
            {
                Console.WriteLine("Ожирение третьей степени");
            }
        }
    }

    class Sports : Person
    {
        public Sports(string name, string surname, int age, int height, int weight, string gender)
        {
            _name = name;
            _surname = surname;
            provero4ka.Age = age;
            provero4ka.Height = height;
            provero4ka.Weight = weight;
            provero4ka.Gender = gender;
        }

        public override void Сaloric(int height, int weight, string gender, int age)
        {
            if (gender == "м" || gender == "m")
            {
                double norma = (88.36 + 13.4 * weight + 4.8 * height - 5.7 * age) * 1.8;
                Console.WriteLine(norma);

            }
            else if (gender == "ж" || gender == "f")
            {
                double norma = (447.6 + 9.2 * weight + 3.1 * height - 4.3 * age) * 1.8;
                Console.WriteLine(norma);
            }
        }

        public override void Water(int weight, string gender)
        {
            if (gender == "м" || gender == "m")
            {
                double norma = 40 * weight + 800;
                Console.WriteLine(norma);
            }
            else if (gender == "ж" || gender == "f")
            {
                double norma = 30 * weight + 800;
                Console.WriteLine(norma);
            }
        }

        public override void IMT(int weight, double height)
        {
            double index;
            index = weight / ((height / 100) * (height / 100));
            if (index < 16)
            {
                Console.WriteLine("Ярко выраженный дефицит массы тела");
            }
            else if (index > 16 && index < 18.5)
            {
                Console.WriteLine("Дефицит массы тела");
            }
            else if (index > 18.5 && index < 25)
            {
                Console.WriteLine("Норма");
            }
            else if (index > 25 && index < 30)
            {
                Console.WriteLine("Предожирение");
            }
            else if (index > 30 && index < 35)
            {
                Console.WriteLine("Ожирение первой степени");
            }
            else if (index > 35 && index < 40)
            {
                Console.WriteLine("Ожирение второй степени");
            }
            else if (index > 40)
            {
                Console.WriteLine("Ожирение третьей степени");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string otvet2;
            Console.WriteLine("Здравствуйте введите ваши данные: ");
            do
            {
                Console.WriteLine("Имя: ");
                string name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Фамилия: ");
                string surname = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Пол: ");
                string gender = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Возраст: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Рост: ");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Вес: ");
                int weight = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                string otvet;
                Console.WriteLine("если вы человек с ограничеными возможностями - нажмите 1, если у вас сидячий образ жизни - 2, если вы ведете умеренный, здоровый образ жизни - 3, если вы спортсмен -4");
                otvet = Console.ReadLine();
                Console.Clear();
                if (otvet == "1")
                {
                    Disabled disabled = new Disabled(name, surname, age, height, weight, gender);
                    Console.WriteLine("Норма калорий: ");
                    disabled.Сaloric(height, weight, gender, age);
                    Console.WriteLine("Норма воды: ");
                    disabled.Water(weight, gender);
                    Console.WriteLine("Показатель состояния вашего тела по ИМТ: ");
                    disabled.IMT(weight, height);
                }
                else if (otvet == "2")
                {
                    Sedentary sedentary = new Sedentary(name, surname, age, height, weight, gender);
                    Console.WriteLine("Норма калорий: ");
                    sedentary.Сaloric(height, weight, gender, age);
                    Console.WriteLine("Норма воды: ");
                    sedentary.Water(weight, gender);
                    Console.WriteLine("Показатель состояния вашего тела по ИМТ: ");
                    sedentary.IMT(weight, height);
                }
                else if (otvet == "3")
                {
                    Healthy healthy = new Healthy(name, surname, age, height, weight, gender);
                    Console.WriteLine("Норма калорий: ");
                    healthy.Сaloric(height, weight, gender, age);
                    Console.WriteLine("Норма воды: ");
                    healthy.Water(weight, gender);
                    Console.WriteLine("Показатель состояния вашего тела по ИМТ: ");
                    healthy.IMT(weight, height);
                }
                else if (otvet == "4")
                {
                    Sports sports = new Sports(name, surname, age, height, weight, gender);
                    Console.WriteLine("Ваша норма калорий: ");
                    sports.Сaloric(height, weight, gender, age);
                    Console.WriteLine("Ваша норма воды: ");
                    sports.Water(weight, gender);
                    Console.WriteLine("Показатель состояния вашего тела по ИМТ: ");
                    sports.IMT(weight, height);
                }
                Console.WriteLine("Хотите ввести данные другого человека? ");
                otvet2 = Console.ReadLine();
            } while (otvet2 == "да" || otvet2 == "Да" || otvet2 == "lf" || otvet2 == "Lf");
        }
    }
}