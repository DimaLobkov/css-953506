using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class Human
    {
        
        private string name ;
        private string surname;
        private string patronymic;
        private int age;
        private int weight;
        private int height;
        private string profession;
        
        public Human()
        {
            name = "Dima";
            surname = "Vasilev";
            patronymic = "Vadimovich";
        }

        public Human(string name, string surname, string patronymic)
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
        }
      
        public string Information { private set;  get; }
    
        public int Parameters { private set; get; }
        public void Parameter(int age, int weight, int height)
        {
            this.age = age;
            this.weight = weight;
            this.height = weight; 
        }
        public void  Parameter()
        {
            age = 60;
            weight = 75;
            height = 190;
        }
        
        public void Prof()
        {
            profession = "Builder";
        }

        public string Prof(int age)
        {

            profession = "Designer";
            return profession;
        }
     
      
        public void Cout()
        {
            Console.WriteLine($"Name:{name}, Surname:{surname}, Patronymic:{patronymic}");
            Console.WriteLine($"Age:{age}, Weidgt:{weight}, Height:{height}");
            Console.WriteLine($"Profession:{profession}");
        }
        public void Cout(int age, int weight, int height, string profession)
        {
            Console.WriteLine();
            Console.WriteLine($"Name:{name}, Surname:{surname}, Patronymic:{patronymic}");
            Console.WriteLine($"Age:{age}, Weidgt:{weight}, Height:{height}");
            Console.WriteLine($"Profession:{profession}");
        }
        
        public string this[string index]
        {
            get
            {
                switch (index)
                {
                    case "name":
                        return name;      
                    case "surname":
                        return surname;
                    default: return null;
                }
            }
            set
            {
                switch(index)
                {
                    case "name":
                        name = value;
                        break;
                    case "surname":
                        surname = value;
                        break;
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            char key, key1;
            Human example1 = new Human();
            Human example2 = new Human("Nick", "Backer", "Cameron");
       
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
                        key1 = Console.ReadKey().KeyChar;
                        switch (key1)
                        {
                            case '1':
                                example2.Cout();
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
                        example1.Parameter(age, weight, height);
                        string profession = example1.Prof(age);

                        Console.WriteLine("Do you want to see all information or only name and surname");
                        Console.WriteLine("All information(1)   Only name and surname(2)");
                        key1 = Console.ReadKey().KeyChar;
                        switch (key1)
                        {
                            case '1':
                                example2.Cout(age, weight, height, profession);
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
