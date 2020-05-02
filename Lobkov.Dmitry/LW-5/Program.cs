using System;

namespace _5
{
    struct Fullname
    {
        public string firstname, lastname, middlename;
    }

    abstract class Human
    {
            //поля
        protected Fullname fullname;
        protected int _age;
        protected bool _isConvicted, _sex;
        public static int birthYear = 2020;

            //конструкторы
        public Human()
        {
            fullname.firstname = "not defined";
        }

        public Human(string firstname, string lastname)
        {
            fullname.firstname = firstname;
            fullname.lastname = lastname;
            _isConvicted = false; 
            _age = 2020 - birthYear;
        }

        public Human(string firstname, string lastname, string middlename) : this(firstname, lastname)
        {
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

        public string Sex
        {
            get
            {
                _sex = !_sex;
                if (_sex)
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
                return _age;
            }
            
            set
            {
                birthYear = value;
                _age = 2020 - birthYear;
            }
        }

        public abstract string KindOfSports { get; set; }

        //индексатор
        public string this[string select]
        {
            get
            {
                switch (select)
                {
                    case "lastname": return fullname.lastname;
                    case "firstname": return fullname.firstname;
                    case "middlename": return fullname.middlename;
                    default: return null;
                }
            }

            set
            {
                switch (select)
                {
                    case "lastname": fullname.lastname = value; break;
                    case "firstname": fullname.firstname = value; break;
                    case "middlename": fullname.middlename = value; break;
                }
            }
        }

            //методы
        public void ShowInfo()
        {
            if (_sex)
            {
                Console.WriteLine("\n\nSex: female");
            }
            else
            {
                Console.WriteLine("\n\nSex: male");
            }

            Console.WriteLine($"Lastname: {fullname.lastname}");
            Console.WriteLine($"Firstname: {fullname.firstname}");
            Console.WriteLine($"Middlename: {fullname.middlename}");
            Console.WriteLine($"Age: {_age}");
            if (_isConvicted)
            {
                Console.WriteLine("Has a criminal record.");
            }
            else
            {
                Console.WriteLine("Has no criminal record.");
            }
        }

        public void ChangeFullname()
        {
            Console.Write("Enter the firstname: ");
            fullname.firstname = Console.ReadLine();
            Console.Write("Enter the lastname: ");
            fullname.lastname = Console.ReadLine();
            Console.Write("Enter the middlename: ");
            fullname.middlename = Console.ReadLine();
        }

        public void CriminalRecord()
        {
            string answer;

            Console.Write("Do you have a criminal record?(\"yes\" or \"no\"): ");
            answer = Console.ReadLine();
            if (answer == "yes")
            {
                _isConvicted = true;
            }
            else if (answer == "no")
            {
                _isConvicted = false;
            }

        }

        //деструктор
        ~Human() { }
    }

    abstract class Sportsman : Human
    {
            //поля
        protected int _height;
        protected float _weight, _record;
        protected string _kindOfSports;
        protected bool _isDoping;

            //перечисление
        enum KindsOfSports
        {
            Jumper = 1,
            Swimmer = 2,
            Weightlifter = 3
        }

            //конструкторы
        public Sportsman(string firstname, string lastname, string middlename, float record) : base(firstname, lastname, middlename)
        {
            _record = record;
        }

            //свойства
        public string IsDoping
        {
            get
            {
                _isDoping = !_isDoping;
                if (_isDoping)
                {
                    return "Doping is detected";
                }
                else
                {
                    return "Doping isn't detected";
                }
            }
        }

        public int Height
        {
            set
            {
                _height = value;
            }
        }

        public float Weight
        {
            set
            {
                _weight = value;
            }
        }

        public string Record
        {
            get
            {
                if(_kindOfSports == KindsOfSports.Jumper.ToString())
                {
                    return $"{_record} meters";
                }

                else if (_kindOfSports == KindsOfSports.Swimmer.ToString())
                {
                    return $"{_record} seconds";
                }

                else
                {
                    return $"{_record} kg";
                }
            }
            set
            {
                float potentialRecord;

                potentialRecord = float.Parse(value);
                if (potentialRecord > _record)
                {
                    _record = potentialRecord;
                }
                else
                {
                    Console.WriteLine("No new record set");
                    _record = 0;
                }
            }
        }

        public override string KindOfSports 
        {
            get
            {
                return _kindOfSports;
            }
            set
            {
                if (value == KindsOfSports.Jumper.ToString())
                {
                    _kindOfSports = KindsOfSports.Jumper.ToString();
                }

                if (value == KindsOfSports.Swimmer.ToString())
                {
                    _kindOfSports = KindsOfSports.Swimmer.ToString();
                }

                if (value == KindsOfSports.Weightlifter.ToString())
                {
                    _kindOfSports = KindsOfSports.Weightlifter.ToString();
                }
            }
        }

        public abstract string IsOutstanding { get; }

            //методы
        public void ChangeParameters()
        {
            int height;
            float weight;
            bool isRight = false;

            while (!isRight)
            {
                Console.Write($"\nCurrent height: {_height} cm\nEnter actual height: ");
                if (int.TryParse(Console.ReadLine(), out height))
                {
                    isRight = true;
                    _height = height;
                }
            }

            isRight = false;
            while (!isRight)
            {
                Console.Write($"\nCurrent weight: {_weight} kg\nEnter actual weight: ");
                if (float.TryParse(Console.ReadLine(), out weight))
                {
                    isRight = true;
                    _weight = weight;

                }
            }
        }

        public void ShowSport()
        {
            Console.WriteLine($"Information about {KindOfSports}");
            Console.WriteLine($"Personal record is {Record}");
        }

        public abstract void PersonalRecord(Sportsman sportsman);

            //деструктор
        ~Sportsman() { }
    }

    class Jumper : Sportsman
    {

            //конструктор
        public Jumper(string firstname, string lastname, string middlename, float record) : base(firstname, lastname, middlename, record) { }

            //свойства
        public override string IsOutstanding 
        {
            get
            {
                if (_record > 5)
                {
                    return "\nThe sportsman is outsctanding.";
                }

                else
                {
                    return "\nThe sportsman isn't outsctanding.";
                }
            }
        }

            //методы
        public override void PersonalRecord(Sportsman jumper)
        {
            float oldRecord = _record;

            Console.WriteLine($"The record: {jumper.Record}");
            Console.Write($"Enter new result: ");
            Record = Console.ReadLine();
            oldRecord = -1 * (oldRecord - _record);
            if (oldRecord > 0.2f && oldRecord < 0.3f)
            {
                Console.WriteLine("Congratulations on an outstanding result");
            }

            else if (oldRecord >= 0.3f)
            {
                Console.WriteLine("Congratulations on such a great record!\nYour achievement is impossible");
            }

            Console.WriteLine($"You raised the record by {oldRecord}");
        }

            //деструктор
        ~Jumper() { }
    }

    class Swimmer : Sportsman
    {

            //конструктор
        public Swimmer(string firstname, string lastname, string middlename, float record) : base(firstname, lastname, middlename, record) { }

            //свойства
        public override string IsOutstanding
        {
            get
            {
                if (_record < 25)
                {
                    return "The sportsman is outsctanding.";
                }

                else
                {
                    return "The sportsman isn't outsctanding.";
                }
            }
        }

            //методы
        public override void PersonalRecord(Sportsman swimmer)
        {
            float oldRecord = _record;

            Console.WriteLine($"The record: {swimmer.Record}");
            Console.Write($"Enter new result: ");
            Record = Console.ReadLine();
            oldRecord = -1 * (oldRecord - _record);
            if (oldRecord > 0.2f && oldRecord < 0.3f)
            {
                Console.WriteLine("Congratulations on an outstanding result");
            }

            else if (oldRecord <= 0.3f)
            {
                Console.WriteLine("Congratulations on such a great record!\nYour achievement is impossible");
            }

            Console.WriteLine($"You raised the record by {oldRecord}");
        }

            //деструктор
        ~Swimmer() { }
    }

    class Weghtlifter : Sportsman
    {

            //конструктор
        public Weghtlifter(string firstname, string lastname, string middlename, float record) : base(firstname, lastname, middlename, record) { }

            //свойства
        public override string IsOutstanding
        {
            get
            {
                if (_record > 5)
                {
                    return "The sportsman is outsctanding.";
                }

                else
                {
                    return "The sportsman isn't outsctanding.";
                }
            }
        }

            //методы
        public override void PersonalRecord(Sportsman weghtlifter)
        {
            float oldRecord = _record;

            Console.WriteLine($"The record: {weghtlifter.Record}");
            Console.Write($"Enter new result: ");
            Record = Console.ReadLine();
            oldRecord = -1 * (oldRecord - _record);
            if (oldRecord > 2f && oldRecord < 3f)
            {
                Console.WriteLine("Congratulations on an outstanding result");
            }

            else if (oldRecord >= 3f)
            {
                Console.WriteLine("Congratulations on such a great record!\nYour achievement is impossible");
            }

            Console.WriteLine($"You raised the record by {oldRecord}");
        }

            //деструктор
        ~Weghtlifter() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string firstname, lastname, middlename;
            int birthYear = 0, select;
            float record;
            bool isRight = false;

            Console.Write("Enter data about human.\nEnter the firstname: ");
            firstname = Console.ReadLine();
            Console.Write("Enter the lastname: ");
            lastname = Console.ReadLine();
            Console.Write("Enter the middlename: ");
            middlename = Console.ReadLine();
            Console.Write("Enter the record: ");
            float.TryParse(Console.ReadLine(), out record);
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

            Human.birthYear = birthYear;
            Console.WriteLine("\tEnter a sportman:\n1)Jumper\n2)Swimmer\n3)Weghtlifter");
            int.TryParse(Console.ReadLine(), out select);
            if(select == 1)
            {
                Sportsman sportsman = new Jumper(firstname, lastname, middlename, record);
                sportsman.ShowInfo();
                sportsman.KindOfSports = "Jumper";
                sportsman.ChangeParameters();
                sportsman.PersonalRecord(sportsman);
                Console.WriteLine($"{sportsman.IsOutstanding}");
            }
            

            else if (select == 2)
            {
                Sportsman sportsman = new Swimmer(firstname, lastname, middlename, record);
                sportsman.KindOfSports = "Swimmer";
                Console.WriteLine($"{sportsman.ShowFullname}");
                sportsman.ShowSport();
                sportsman.CriminalRecord();
            }

            else if (select == 3)
            {
                Sportsman sportsman = new Weghtlifter(firstname, lastname, middlename, record);
                sportsman.KindOfSports = "Weghtlifter";
                Console.WriteLine($"{sportsman.IsDoping}");
                sportsman.PersonalRecord(sportsman);
                Console.Write("Lastname: ");
                sportsman["lastname"] = Console.ReadLine();
                Console.WriteLine($"Current age: {sportsman.Age} years\nEnter actual birth year: ");
                int.TryParse(Console.ReadLine(), out birthYear);
                sportsman.Age = birthYear;
            }
        }
    }
}