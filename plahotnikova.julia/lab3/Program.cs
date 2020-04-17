using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (Console.ReadLine() == "1")
            //{
            //    var human = ReadHumanFromConsole();
            //    Console.WriteLine(human1.ToString());
            //}

            var human = ReadHumanFromConsole();

            Console.WriteLine(human.ToString());

            Console.WriteLine();

            Console.WriteLine("Age of the human: " + human.GetFullYears());
            Console.WriteLine("Body mass index of the human: " + human.GetBodyMassIndex());

            Console.WriteLine("Name: " + human.Firstname);
            Console.WriteLine("Name: " + human["Firstname"]);

            human.AddWeight();
            Console.WriteLine("Weigth: " + human.Weight);
            human.AddWeight(5);
            Console.WriteLine("Weigth: " + human.Weight);

            Console.WriteLine("Body mass index of the human: " + human.GetBodyMassIndex());
            Console.ReadKey();
        }

        static Human ReadHumanFromConsole()
        {
            Console.WriteLine("Enter firstname:");
            var firstname = Console.ReadLine();

            Console.WriteLine("Enter lastname:");
            var lastname = Console.ReadLine();

            Console.WriteLine("Enter birthdate:");
            var birthdate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter sex:");
            var sex = (Sex)Enum.Parse(typeof(Sex), Console.ReadLine());

            Console.WriteLine("Enter heigth:");
            var heigth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter weigth:");
            var weigth = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            var human = new Human(firstname, lastname, birthdate, sex, heigth, weigth);

            return human;
        }
    }
}
