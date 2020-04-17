using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Human
    {
        //полe
        private string _name;
        private string _surname;
        private string _patronymic;
        private int _age;
        private int _weight;
        private int _height;
        private string _profession;
        private int[] PIN = new int[4] {0, 8, 0, 9 };
        private static int count;

        //конструктор
        public Human()
        {
            _name = "Dima";
            _surname = "Vasilev";
            _patronymic = "Vadimovich";
            count++;
        }

        public Human(string name, string surname, string patronymic)
        {
            this._name = name;
            this._surname = surname;
            this._patronymic = patronymic;
            count++;
        }
        //свойство(автосвойство)
        public string Information { private set;  get; }
    
        public int Parameters { private set; get; }
        // свойство
        public int IfAge
        {
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Age must be from 0 to 100 years");
                }

                else
                {
                    _age = value;
                }

            }

            get
            {
                return _age;
            }
        }
        // индексатор
        public int this [int i]
        {
            get
            {
                return PIN[i];
            }
            set
            {
                PIN[i] = value;
            }
        }

        //метод
        public static void ShowCount()
        {
            Console.Clear();
            Console.Write("Count of people: ");
            Console.Write(Human.count.ToString());
        }
        public void Parameter(int age, int weight, int height)
        {
            this._age = age;
            this._weight = weight;
            this._height = weight; 
        }
        public void  Parameter()
        {
            _age = 60;
            _weight = 75;
            _height = 190;
        }
        
        public void Prof()
        {
            _profession = "Builder";
            for(int i = 0; i < 3; i++)
            {
                PIN[i] = i + 2;
            }
        }

        public string Prof(int age)
        {

            _profession = "Designer";
            return _profession;
        }
     
        
        public void Cout()
        {
            Console.WriteLine($"Name:{_name}, Surname:{_surname}, Patronymic:{_patronymic}");
            Console.WriteLine($"Age:{_age}, Weidgt:{_weight}, Height:{_height}");
            Console.WriteLine($"Profession:{_profession}");
            Console.Write("PIN: ");
            Random rand = new Random();
        }
        public void Cout(int age, int weight, int height, string profession)
        {
            Console.WriteLine();
            Console.WriteLine($"Name:{_name}, Surname:{_surname}, Patronymic:{_patronymic}");
            Console.WriteLine($"Age:{age}, Weidgt:{weight}, Height:{height}");
            Console.WriteLine($"Profession:{profession}");
            Console.Write("PIN: ");
        }
        //индексатор
        public string this[string index]
        {
            get
            {
                switch (index)
                {
                    case "name":
                        return _name;      
                    case "surname":
                        return _surname;
                    default: return null;
                }
            }
            set
            {
                switch(index)
                {
                    case "name":
                        _name = value;
                        break;
                    case "surname":
                        _surname = value;
                        break;
                }
            }
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            char key;
            Human example1 = new Human();
            Human example2 = new Human("Nick", "Backer", "Cameron");
            Human password = new Human();
            Console.WriteLine("Do you want to change PIN?");
            Console.WriteLine("Yes(1)   No(2)");
            key = Console.ReadKey().KeyChar;
            switch (key)
            {
                case '1':
                    Console.Clear();
                    Console.WriteLine("Enter new password(4 numbers)");
                    for (int i = 0; i < 4; i++)
                    {
                        password[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    break;
                case '2': break;
                default:
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Error");
                    Console.WriteLine("You can enter only 1 or 2");
                    break;

            }

            Human.ShowCount();
            Console.WriteLine();

            Console.WriteLine("Choose the person:");
            Console.WriteLine("The first(1)   The second(2)");
            Console.WriteLine("(If you choose the second person, you will have to enter all information)");
             key = Console.ReadKey().KeyChar;
            switch (key)
            {
                case '1':
                    {
                        Console.Clear();
                        //first
                        Console.WriteLine("Informations of the first person:");
                        example1.Parameter();
                        example1.Prof();

                        Console.WriteLine("Do you want to see all information or only name and surname");
                        Console.WriteLine("All information(1)   Only name and surname(2)");
                        key = Console.ReadKey().KeyChar;
                        switch (key)
                        {
                            case '1':
                                example1.Cout();
                                for (int i = 0; i < 4; i++)
                                {
                                    Console.Write(password[i]);
                                }
                                break;
                            case '2':
                                Console.WriteLine();
                                Console.WriteLine($"Name:{example1["name"]}, Surname:{example1["surname"]}");

                                break;
                            default:
                                Console.WriteLine();
                                Console.WriteLine("Error");
                                Console.WriteLine("You can enter only 1 or 2");
                                break;
                        }
                        break;
                    }
                case '2':
                    {
                        //second

                        Console.WriteLine("Enter some information about the second person:");
                        Console.WriteLine("Enter age:");

                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter weight:");
                        int weight = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter height:");
                        int height = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informations of the second person:");
                        Console.WriteLine("");
                        example2.Parameter(age, weight, height);
                        string profession = example2.Prof(age);

                        Console.WriteLine("Do you want to see all information or only name and surname");
                        Console.WriteLine("All information(1)   Only name and surname(2)");
                        key = Console.ReadKey().KeyChar;
                        switch (key)
                        {
                            case '1':
                                example2.Cout(age, weight, height, profession);
                                for (int i = 0; i < 4; i++)
                                {
                                    Console.Write(password[i]);
                                }
                                break;
                            case '2':
                                Console.WriteLine();
                                Console.WriteLine($"Name:{example2["name"]}, Surname:{example2["surname"]}");

                                break;
                            default:
                                Console.WriteLine();
                                Console.WriteLine("Error");
                                Console.WriteLine("You can enter only 1 or 2");
                                break;
                        }
                        break;
                    }
                default:
                    Console.WriteLine();
                    Console.WriteLine("Error");
                    Console.WriteLine("You can enter only 1 or 2"); 
                    break;
            }
                

          
           
           

        }
    }
}
