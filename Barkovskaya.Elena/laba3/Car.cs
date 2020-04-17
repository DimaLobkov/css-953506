using System;

namespace laba3
{
    class Car   
    {
        //Поля
        private int _age;
        private string _breakdowne, _chassis_type, _color, _mark, _model;
        private bool _isСapable = false, _breakage = false;
        public static int production_year;

        //Конструкторы 
        public Car(string mark, string model, string color, string chassis_type)
        {
            _age = 2020 - production_year;
            _mark = mark;
            _model = model;
            _color = color;
            if (chassis_type == "wheeled" || chassis_type == "tracked" || chassis_type == "mixed" || chassis_type == "magnetic cushion")
                _chassis_type = chassis_type;
            else _chassis_type = "unknown";
        }

        public Car(string mark)
        {
            _age = 2020 - production_year;
            _mark = mark;
            _model = "uknown";
            _color = "uknown";
            _chassis_type = "unkown";
        }

        public Car(string mark, string model)
        {
            _age = 2020 - production_year;
            _mark = mark;
            _model = model;
            _color = "uknown";
            _chassis_type = "unkown";
        }

        public Car() { }
        
        //Свойства
        public string Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                _mark = value;
            }
        }

        public int Age
        {
            get
            {
                return 2020 - production_year;
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public bool IsСapable
        {
            get
            {
                return _isСapable;
            }
        }

        public string Breakdowne
        {
            get
            {
                if (_breakage) return _breakdowne;
                return $"{_mark} is not broken";
            }
            set
            {
                _breakage = true;
                _breakdowne = value;
            }
        }

        //Индексатор
        public string this[string choice]
        {
            get
            {
                switch (choice)
                {
                    case "mark": return _mark;
                    case "model": return _model;
                    case "color": return _color;
                    default: return null;
                }
            }
            set
            {
                switch (choice)
                {
                    case "mark":_mark = value; break;
                    case "model":_model = value; break;
                    case "color":_color = value; break;
                }
            }
        }

        //Методы
        public void ShowInfo()
        {
            Console.WriteLine($"mark - {_mark}");
            Console.WriteLine($"model - {_model}");
            Console.WriteLine($"color - {_color}");
            Console.WriteLine($"chassis_type - {_chassis_type}");
            Console.WriteLine($"age - {_age}");
            Console.WriteLine($"breakdowne - {Breakdowne}");
            if (_isСapable)
                Console.WriteLine($"status - in a landfill(use <Restore / throw in landfill> to repair)");
            else
                Console.WriteLine($"status - capable");
        }

        public void CarDie()
        {
            _isСapable = true;
        }

        public void Restore()
        {
            _isСapable = false;
        }

        //Деструктор
        ~Car() { }
    }
    
    class Program
    {
        static void Main()
        {
            bool flag = true;
            char choice;
            string mark, model, color, chassis_type;
            int production_year = 0;
            Car car;

            Console.WriteLine("Enter mark, model and color");
            mark = Console.ReadLine();
            model = Console.ReadLine();
            color = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter chassis_type (wheeled/tracked/mixed/magnetic cushion)");
            chassis_type = Console.ReadLine();
            Console.Clear();

            do
            {
                Console.WriteLine("Enter production year");
                int.TryParse(Console.ReadLine(), out production_year);
                if (production_year <= 2020)
                    flag = false;
                else Console.WriteLine("Incorrect input. Now we in 2020 year");
            } while (flag);
            Console.Clear();

            Car.production_year = production_year;
            car = new Car(mark, model, color , chassis_type);
            do
            {
                Console.WriteLine("1 - Show info\n2 - Restore / throw in landfill\n3 - Change mark\n4 - Change model\n5 - Change color\n6 - Install breakdown\n7 - Show mark and model\n8 - Exit");
                choice = Console.ReadKey().KeyChar;
                Console.Clear();

                switch (choice)
                {
                    case '1':
                        car.ShowInfo();
                        Console.ReadKey();
                        break;
                    case '2':
                        if (car.IsСapable)
                            car.Restore();
                        else car.CarDie();
                        break;
                    case '3':
                        Console.Write("mark - ");
                        car["mark"] = Console.ReadLine();
                        break;
                    case '4':
                        Console.Write("model - ");
                        car["model"] = Console.ReadLine();
                        break;

                    case '5':
                        Console.Write("color - ");
                        car["color"] = Console.ReadLine();
                        break;
                    case '6':
                        Console.Write("disease - ");
                        car.Breakdowne = Console.ReadLine();
                        break;
                    case '7':
                        Console.Clear();
                        Console.Write("Your car is " + car["mark"] + " " + car["model"]);
                        Console.ReadKey();
                        break;
                    case '8':
                        return;
                }
                Console.Clear();
            } while (true);
        }
    }
}
