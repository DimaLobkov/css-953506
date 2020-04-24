using System;

namespace _3
{
    class Human
    {
            //поля
        private string m_firstname, m_lastname, m_middlename;
        private int m_age, m_height;
        private float m_weight;
        private bool m_isConvicted, m_sex;
        public static int m_birthYear = 2020;

            //конструкторы
        public Human()
        {
            m_firstname = "";
            m_lastname = "not defined";
            m_middlename = "";
            m_age = 0;
            m_height = 0;
            m_weight = 0f;
            m_isConvicted = false;
        }

        public Human(string firstname, string lastname)
        {
            m_firstname = firstname;
            m_lastname = lastname;
            m_isConvicted = false; 
            m_age = 2020 - m_birthYear;
        }

        public Human(string firstname, string lastname, string middlename)
        {
            m_firstname = firstname;
            m_lastname = lastname;
            m_middlename = middlename;
            m_isConvicted = false;
            m_age = 2020 - m_birthYear;
        }

            //свойства
        public string ShowFullname
        {
            get
            {
                return $"{m_lastname} {m_firstname} {m_middlename}";
            }
        }

        public string Sex
        {
            get
            {
                m_sex = !m_sex;
                if (m_sex)
                {
                    return "female";
                }
                else
                {
                    return "male";
                }
            }
        }

        public int Age
        {
            get
            {
                return m_age;
            }
            
            set
            {
                m_birthYear = value;
                m_age = 2020 - m_birthYear;
            }
        }

            //индексатор
        public string this[string select]
        {
            get
            {
                switch (select)
                {
                    case "lastname": return m_lastname;
                    case "firstname": return m_firstname;
                    case "middlename": return m_middlename;
                    default: return null;
                }
            }

            set
            {
                switch (select)
                {
                    case "lastname": m_lastname = value; break;
                    case "firstname": m_firstname = value; break;
                    case "middlename": m_middlename = value; break;
                }
            }
        }

            //методы
        public void ShowInfo()
        {
            if (m_sex)
            {
                Console.WriteLine("\n\nSex: female");
            }
            else
            {
                Console.WriteLine("\n\nSex: male");
            }

            Console.WriteLine($"Lastname: {m_lastname}");
            Console.WriteLine($"Firstname: {m_firstname}");
            Console.WriteLine($"Middlename: {m_middlename}");
            Console.WriteLine($"Age: {m_age}");
            Console.WriteLine($"Height: {m_height}");
            Console.WriteLine($"Weight: {m_weight}");
            if (m_isConvicted)
            {
                Console.WriteLine("Has a criminal record.");
            }
            else
            {
                Console.WriteLine("Has no criminal record.");
            }
        }

        public void ChangeParameters()
        {
            int height;
            float weight;
            bool isRight = false;

            while (!isRight)
            {
                Console.Write($"\nCurrent height: {m_height} cm\nEnter actual height:");
                if (int.TryParse(Console.ReadLine(), out height))
                {
                    isRight = true;
                    m_height = height;
                }
            }

            isRight = false;
            while (!isRight)
            {
                Console.WriteLine($"\nCurrent weight: {m_weight} kg\nEnter actual weight:");
                if (float.TryParse(Console.ReadLine(), out weight))
                {
                    isRight = true;
                    m_weight = weight;

                }
            }
        }

        public void ChangeFullname()
        {
            Console.Write("Enter the firstname: ");
            m_firstname = Console.ReadLine();
            Console.Write("Enter the lastname: ");
            m_lastname = Console.ReadLine();
            Console.Write("Enter the middlename: ");
            m_middlename = Console.ReadLine();
        }

        public void CriminalRecord()
        {
            string answer;

            Console.Write("Do you have a criminal record?(\"yes\" or \"no\"): ");
            answer = Console.ReadLine();
            if (answer == "yes")
            {
                m_isConvicted = true;
            }
            else
            {
                m_isConvicted = false;
            }

        }

        //деструктор
        ~Human() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string firstname, lastname, middlename;
            int birthYear = 0, select;
            bool isRight = false;

            Console.Write("Enter data about human.\nEnter the firstname: ");
            firstname = Console.ReadLine();
            Console.Write("Enter the lastname: ");
            lastname = Console.ReadLine();
            Console.Write("Enter the middlename: ");
            middlename = Console.ReadLine();
            while (!isRight)
            {
                Console.WriteLine("Enter birth year: ");
                if (!int.TryParse(Console.ReadLine(), out birthYear))
                {
                    isRight = false;
                }

                if (birthYear > 2020 || birthYear < 1900)
                {
                    isRight = false;
                }
                else
                {
                    isRight = true;
                }
            }

            Human.m_birthYear = birthYear;

            Human human;

            human = new Human(firstname, lastname, middlename);

            do
            {
                Console.Write("\t\tMenu\n1) Show the data\n2) Enter/change optional data\n3) Change fullname\n4) Change birth year");
                Console.Write("\n5) Change the lastname\n6) Change the firstname\n7) Change the middlename\n8) Change the sex");
                Console.Write("\n9) Show the fullname\n10) Criminal record\n11) Exit\n\nYour select: ");
                int.TryParse(Console.ReadLine(), out select);
                switch (select)
                {
                    case 1: 
                        human.ShowInfo();
                        break;
                    case 2: 
                        human.ChangeParameters();
                        break;
                    case 3: 
                        human.ChangeFullname();
                        break;
                    case 4:
                        Console.WriteLine($"Current age: {human.Age} years\nEnter actual birth year: ");
                        int.TryParse(Console.ReadLine(), out birthYear);
                        human.Age = birthYear;
                        break;
                    case 5:
                        Console.Write("Lastname: ");
                        human["lastname"] = Console.ReadLine();
                        break;
                    case 6:
                        Console.Write("Firstname: ");
                        human["firstname"] = Console.ReadLine();
                        break;
                    case 7:
                        Console.Write("Middlename: ");
                        human["middlename"] = Console.ReadLine();
                        break;
                    case 8:
                        Console.WriteLine($"Sex: {human.Sex}");
                        break;
                    case 9:
                        Console.WriteLine($"Fullname: {human.ShowFullname}");
                        break;
                    case 10:
                        human.CriminalRecord();
                        break;
                    case 11:
                        return;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            } while (isRight);
        }
    }
}