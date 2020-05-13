using System;
using System.Collections.Generic;

namespace laba
{
    interface ISpecifications
    {
        int Experience { get; set; }
        string IqGet { get; }
        int IqSet { set; }
        string Recommend { get; set; }
        string Scheduled { get; set; }
    }

    interface IPresent
    {
        void Show();
    }

    struct Fullname
    {
        public string firstname, lastname, middlename;
    }

    class Human
    {
        //поля
        protected Fullname fullname;
        protected bool _isConvicted;

        //конструктор
        public Human(string firstname, string lastname, string middlename)
        {
            fullname.firstname = firstname;
            fullname.lastname = lastname;
            fullname.middlename = middlename;
        }

        //свойства
        public string ShowFullname
        {
            get
            {
                return $"{fullname.lastname} {fullname.firstname} {fullname.middlename}";
            }
        }

        public string IsConvicted
        {
            get
            {
                if (_isConvicted)
                {
                    return "yes";
                }

                else
                {
                    return "no";
                }
            }

            set
            {
                if (value == "yes")
                {
                    Console.WriteLine("Was it a suspended sentence? (\"yes\" or \"no\")");
                    string isSuspended = Console.ReadLine();
                    if (isSuspended == "yes")
                    {
                        Console.WriteLine("How many years have passed since the verdict?");
                        int years;
                        int.TryParse(Console.ReadLine(), out years);
                        if (years > 9)
                        {
                            _isConvicted = false;
                        }

                        else _isConvicted = true;
                    }

                    else
                    {
                        _isConvicted = true;
                    }
                }

                else
                {
                    _isConvicted = false;
                }
            }
        }
    }

    class Employee : Human, ISpecifications, IPresent
    {
        //поля
        protected int _experience;
        protected bool _isRecommend, _isUnscheduled;
        protected IQ _iq;

        //перечисление
        public enum IQ
        {
            low = 1,
            lowerMiddle,
            middle,
            upperMiddle,
            high
        }

        //конструктор
        public Employee(string firstname, string lastname, string middlename) : base(firstname, lastname, middlename) { }

        //свойства
        public int Experience
        {
            get
            {
                return _experience;
            }

            set
            {
                _experience = value;
            }
        }

        public string IqGet
        {
            get
            {
                switch (_iq)
                {
                    case IQ.low:
                        return "low IQ";
                    case IQ.lowerMiddle:
                        return "lower-middle IQ";
                    case IQ.middle:
                        return "middle IQ";
                    case IQ.upperMiddle:
                        return "upper-middle IQ";
                    case IQ.high:
                        return "high IQ";
                    default:
                        return "something gone wrong...";
                }
            }
        }

        public int IqSet
        {
            set
            {
                if (value < 70)
                {
                    _iq = IQ.low;
                }

                else if (value > 130)
                {
                    _iq = IQ.high;
                }

                else if (value > 110)
                {
                    _iq = IQ.upperMiddle;
                }

                else if (value > 90)
                {
                    _iq = IQ.middle;
                }

                else
                {
                    _iq = IQ.lowerMiddle;
                }
            }
        }

        public IQ Iq
        {
            get
            {
                return _iq;
            }
        }

        public string Recommend
        {
            get
            {
                if (_isRecommend)
                {
                    return "yes";
                }

                else
                {
                    return "no";
                }
            }

            set
            {
                if (value == "yes")
                {
                    _isRecommend = true;
                }

                else
                {
                    _isRecommend = false;
                }
            }
        }

        public string Scheduled
        {
            get
            {
                if (_isUnscheduled)
                {
                    return "yes";
                }

                else
                {
                    return "no";
                }
            }

            set
            {
                if (value == "yes")
                {
                    _isUnscheduled = true;
                }

                else
                {
                    _isUnscheduled = false;
                }
            }
        }

        //методы
        public void Show()
        {
            Console.WriteLine($"{fullname.lastname} {fullname.firstname} {fullname.middlename}");
            Console.WriteLine($"Is convicted? - {IsConvicted}");
            Console.WriteLine($"Experience: {Experience}");
            Console.WriteLine($"IQ: {IqGet}");
            Console.WriteLine($"Is recommended? - {Recommend}");
            Console.WriteLine($"Is unscheduled? - {Scheduled}");
        }


    }

    class TheBestOne : IComparer<Employee>
    {
        public int Compare(Employee obj1, Employee obj2)
        {
            int counter1 = 0, counter2 = 0;

            if (obj1.IsConvicted != obj2.IsConvicted)
            {
                if (obj1.IsConvicted == "no")
                {
                    counter1++;
                }

                else
                {
                    counter2++;
                }
            }

            if (obj1.Experience > obj2.Experience)
            {
                counter1++;
            }

            else if (obj1.Experience < obj2.Experience)
            {
                counter2++;
            }

            if (obj1.Iq > obj2.Iq)
            {
                counter1++;
            }

            else if (obj1.Iq < obj2.Iq)
            {
                counter2++;
            }

            if (obj1.Recommend != obj2.Recommend)
            {
                if (obj1.Recommend == "yes")
                {
                    counter1++;
                }

                else
                {
                    counter2++;
                }
            }

            if (obj1.Scheduled != obj2.Scheduled)
            {
                if (obj1.Scheduled == "yes")
                {
                    counter1++;
                }

                else
                {
                    counter2++;
                }
            }

            if (counter1 > counter2)
            {
                return 1;
            }

            else if (counter2 > counter1)
            {
                return -1;
            }

            return 0;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Dmitry", "Lobkov", "Sergeevich");
            Employee employee2 = new Employee("Ivan", "Ivanov", "Ivanovich");

            Console.Write($"Enter data about the first employee: {employee1.ShowFullname}\nIs convicted?(\"yes\" or \"no\"): ");
            employee1.IsConvicted = Console.ReadLine();
            Console.Write("Enter work experience: ");
            employee1.Experience = int.Parse(Console.ReadLine());
            Console.Write("Enter IQ: ");
            employee1.IqSet = int.Parse(Console.ReadLine());
            Console.Write("Is recommended?(\"yes\" or \"no\"): ");
            employee1.Recommend = Console.ReadLine();
            Console.Write("Is unscheduled?(\"yes\" or \"no\"): ");
            employee1.Scheduled = Console.ReadLine();
            Console.Write($"Enter data about the second employee: {employee2.ShowFullname}\nIs convicted?(\"yes\" or \"no\"): ");
            employee2.IsConvicted = Console.ReadLine();
            Console.Write("Enter work experience: ");
            employee2.Experience = int.Parse(Console.ReadLine());
            Console.Write("Enter IQ: ");
            employee2.IqSet = int.Parse(Console.ReadLine());
            Console.Write("Is recommended?(\"yes\" or \"no\"): ");
            employee2.Recommend = Console.ReadLine();
            Console.Write("Is unscheduled?(\"yes\" or \"no\"): ");
            employee2.Scheduled = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("1)Information about the first employee\n2)Information about the second employee\n3)Compare");
            int select = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (select)
            {
                case 1:
                    employee1.Show();
                    break;
                case 2:
                    employee2.Show();
                    break;
                case 3:
                    TheBestOne theBestOne = new TheBestOne();
                    int compareResult = theBestOne.Compare(employee1, employee2);
                    Console.Write($"The recommended employee is ");
                    if (compareResult == 1)
                    {
                        employee1.Show();
                    }

                    else if (compareResult == -1)
                    {
                        employee2.Show();
                    }

                    else
                    {
                        Console.Write($"both employees");
                    }
                    break;
            }
        }
    }
}