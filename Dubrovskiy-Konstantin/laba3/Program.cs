using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            //----------- КЛАСС ЧЕЛОВЕК -> РАБОТНИК -> РАБОТНИКИ РАЗНЫХ СПЕЦИАЛЬНОСТЕЙ ----------------------

            Worker worker1 = new Worker();           
            worker1.Filling("Ivanov Ivan", 25, "manager", 8);   //Полный метод
            double pay = worker1.Payroll(); //Можно получить если поставить public в методе класса
            Console.WriteLine("{0}", pay.ToString());
            worker1.PrintInfo();

            Console.WriteLine();
            Worker worker2 = new Worker();
            worker2.Filling("waiter", 2);   //Сокращенный перегруженный метод
            worker2.PrintInfo();

            Console.WriteLine();
            Worker worker3 = new Worker();
            worker3.Filling("dishwasher", 0);   //Сокращенный перегруженный метод
            worker3.Name = "Petrov Petr";       // + Свойства
            worker3.Age = 12;                   //
            Console.WriteLine("Имя: {0}", worker3.Name);
            worker3.PrintInfo();

            Console.WriteLine();
            Worker worker4 = new Worker();
            worker4.Filling("Sidorov Sidr", 32, "cook", 10);    //Полный метод
            string str = "Специальность: " + worker4["speciality"] + "\t Опыт работы: " + worker4["experience"];    // Индексатор
            Console.WriteLine("Имя: {0} \t {1}", worker4.Name, str);

            Console.WriteLine();
            Console.WriteLine("Всего работников: {0}", Worker.Counter.ToString());  // Статический "счетчик"

            //Конец:
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
