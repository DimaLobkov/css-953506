using System;

namespace human
{
    class Person
    {
        //_Поля_
        private string name, surname;
        private int height;
        private int weight;
        private string gender;
        private int age;
        private string career;
        private static string start = "Здравствуйте, введите параметры определенного человека.";
        //_Конструкторы_
        public Person() { }
        public Person(string n, string s) : this()
        {
            name = n;
            surname = s;
        }
        public Person(string n, string s, string g, int h, int w) : this(n, s)
        {
            gender = g;
            height = h;
            weight = w;
        }
        //_Свойства_
        public int Age//свойство для проверки по возрасту, если человека не существует или ему меньше 16 лет, программа завершает работу, если человек существует - продолжает работу
        {
            get { return age; }
            set
            {
                if (value == 0 || value > 120)
                {
                    Console.WriteLine("Такого человека не существует");
                    Environment.Exit(-1);
                }
                else if (value < 16)
                {
                    Console.WriteLine("Извините, программа расчитана на людей старше 16 лет");
                    Environment.Exit(-1);
                }
                else
                {
                    age = value;
                }
            }
        }
        public string Career//свойство по вопросу рода деятельности
        {
            get { return career; }
            set
            {
                if (value == "работает")
                {
                    Console.WriteLine("В сфере IT?");
                    string otvet;
                    otvet = Console.ReadLine();
                    if (otvet == "да")
                    {
                        Console.WriteLine("Здорово!");
                        career = value;
                    }
                    else if (otvet == "нет")
                    {
                        Console.WriteLine("Зря, сейчас это очень востребованно!");
                        career = value;
                    }
                }
                else if (value == "учится")
                {
                    Console.WriteLine("В БГУИР?");
                    string otvet;
                    otvet = Console.ReadLine();
                    if (otvet == "да")
                    {
                        Console.WriteLine("Здорово!");
                        career = value;
                    }
                    else
                    {
                        Console.WriteLine("Жаль,что не в БГУИР!");
                        career = value;
                    }
                }
                else if (value == "учится и работает")
                {
                    Console.WriteLine("Надеюсь, что ваша работа не препятствует вашему обучению!");
                    career = value;
                }
                else
                {
                    Console.WriteLine("Странный ответ, человек в вашем возрасте должен чем-то заниматься");
                    career = value;
                }
            }
        }
        //_Методы_ (перегрузка)
        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name} ");
            Console.WriteLine($"Фамилия: {surname} ");
            Console.WriteLine($"Возраст: {Age} ");
            Console.WriteLine($"Рост:{height} ");
            Console.WriteLine($"Вес:{weight} ");
            Console.WriteLine($"Пол:{gender} ");
            Console.WriteLine($"Род деятельности: {Career}  ");
        }
        public void GetInfo(int h, int w, string g, int a)//расчет нормы килокалорий
        {
            if (g == "м")
            {
                double n = 88.36 + 13.4 * w + 4.8 * h - 5.7 * a;
                Console.WriteLine(n);

            }
            else if (g == "ж")
            {
                double n = 447.6 + 9.2 * w + 3.1 * h - 4.3 * a;
                Console.WriteLine(n);
            }
        }
        public void GetInfo(int w, string g)//расчет нормы воды
        {
            if (g == "м")
            {
                double n = 40 * w;
                Console.WriteLine(n);
            }
            else if (g == "ж")
            {
                double n = 30 * w;
                Console.WriteLine(n);
            }
        }
        static public string Start()
        {
            return start;
        }
        ~Person() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string otvet;
            do
            {
                Console.WriteLine(Person.Start());
                Console.WriteLine("Введите имя: ");
                string name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Введите фамилию: ");
                string surname = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Введите рост(см): ");
                string hstr = Console.ReadLine();
                Console.Clear();
                int height = Convert.ToInt32(hstr);
                Console.WriteLine("Введите вес(кг): ");
                string wstr = Console.ReadLine();
                int weight = Convert.ToInt32(wstr);
                Console.Clear();
                Console.WriteLine("Введите пол - 'м' или 'ж': ");
                string gender = Console.ReadLine();
                Console.Clear();
                Person hwg = new Person(name, surname, gender, height, weight);
                Console.WriteLine("Введите возраст: ");
                hwg.Age = Convert.ToInt32(Console.ReadLine());
                int age = hwg.Age;
                Console.Clear();
                Console.WriteLine("Суточная норма килокалорий по формуле Харриса-Бенедикта: ");
                hwg.GetInfo(height, weight, gender, age);
                Console.WriteLine("Суточная норма потребления воды (в мл): ");
                hwg.GetInfo(weight, gender);
                Console.WriteLine("Этот человк 'учится', 'работает' или 'учится и работает'? ");
                string career = Console.ReadLine();
                hwg.Career = career;
                Console.WriteLine("Вывод информации о данном человеке: ");
                hwg.GetInfo();
                Console.WriteLine("Хотите ввести информацию о другом человеке?");
                otvet = Console.ReadLine();
                Console.Clear();
            } while (otvet == "да");
        }
    }
}