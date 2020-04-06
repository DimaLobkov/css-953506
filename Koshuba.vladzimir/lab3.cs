using System;

namespace _3_2
{
    public class Person
    {
        protected string name;
        protected int age;
        //-------- свойства класса ----------
        public string Name { set; get; }
        public int Age
        {
            set
            {
                if (value < 16) Console.WriteLine("Не учится в Университете", value);
                else age = value;
            }
            get
            {
                return age;
            }
        }
    }
    public class Student : Person
    {
        protected string speciality;
        protected int numbergroup;
        protected int cost;
        //статическиt св-ва класса -  подсчет количества  Student
        protected static int counter = 0;
        public Student()
        {
            counter++;
        }
        public static int Counter
        {
            get
            {
                return counter;
            }
        }
        public void Filling(string name, int age, string speciality, int numbergroup)    // полное заполнение 
        {
            this.name = name;
            this.age = age;
            this.speciality = speciality;
            this.numbergroup = numbergroup;
        }
        public void Filling(string speciality, int numbergroup)  // перегруженный метод для сокр. заполнения
        {
            this.speciality = speciality;
            this.numbergroup = numbergroup;
        }
        public double Payment()
        {
            if (speciality == "ИиТП") cost = 980;
            else if (speciality == "ПОИТ") cost = 1000;
            else if (speciality == "ВМСиС") cost = 800;
            else if (speciality == "Асои") cost = 720;
            else cost = 0;    //не учишься в BSUIR(
            return cost;
        }
        public void Info()
        {
            double need = Payment();

            if (name != null && age != 0) Console.WriteLine("Имя: {0}\t \nВозраст: {1} \t", name, age.ToString());
            Console.WriteLine("Специальность: {0} \t Оплата: {1} \t Ноиер группы {2}", speciality, cost.ToString(), numbergroup.ToString());
        }
    }
    class number
    {
        int[] arr;
        public int Length;
        public number(int Size)
        {
            arr = new int[Size];
            Length = Size;
        }
        //индексатор
        public int this[int index]
        {
            set
            {
                arr[index] = value;
            }

            get
            {
                return arr[index];
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            number arr1 = new number(Size: 3);
            for (int i = 0; i < 3; i++) {; ; }

            Student student1 = new Student();
            student1.Filling("Vova koshuba", 25, "ПОИТ", 07);   //полный метод
            double pay = student1.Payment(); //можно получить если поставить public в методе класса
            Console.WriteLine($"{pay.ToString()}");
            arr1[0] = 95350028;
            Console.Write("\n{0}\t", arr1[0]);
            student1.Info();

            Console.WriteLine();

            Student student2 = new Student();
            student2.Filling("ВМСиС", 02);   //Сокращенный перегруженный метод
            student2.Info();
            arr1[1] = 95350061;
            Console.Write("\n{0}\t", arr1[1]);
            Console.WriteLine();

            Student student3 = new Student();
            student3.Filling("ИиТП", 06);   // Сокращенный перегруженный метод
            student3.Name = "ne Vova Koshuba";   // + свойства
            student3.Age = 17;
            arr1[2] = 95350056;
            Console.Write("\n{0}\t", arr1[2]);
            Console.WriteLine("Имя: {0}", student3.Name);
            student3.Info();
                      
            Console.WriteLine();
            Console.WriteLine("Всего работников: {0}", Student.Counter.ToString());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}


