using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Human myHuman = new Human("Helga", "Troelsen");
            myHuman.humanPrintInfo();
            Console.WriteLine($"Get value from property Age - {myHuman.Age}");
            Console.WriteLine($"Calculate body mass index - {myHuman.bodyMassIndex()}");
            Console.WriteLine($"Call static method getID - {Human.getID()}");

            Console.WriteLine("Enter field name ('first name' or 'last name') - ");
            string fieldName = Console.ReadLine();
            Console.WriteLine(myHuman[fieldName]);
            Console.WriteLine("Enter new value - ");
            myHuman[fieldName] = Console.ReadLine();
            Console.WriteLine($"new value in {fieldName} is {myHuman[fieldName]}");
            myHuman.humanPrintInfo();
            Console.WriteLine("");

            Student electrician = new Student("Joakim", "Broden");
            electrician.Age = 18;
            electrician.weight = 70;
            electrician.height = 185;
            electrician.course = 2;
            electrician.faculty = "engineering electronics";
            electrician.speciality = "electrical engineer";

            electrician.studentPrintInfo();
            Console.WriteLine("");

            Student programmer = new Student("Pär", "Sundström");
            programmer.Age = 20;
            programmer.weight = 60;
            programmer.height = 172;
            programmer.course = 3;
            programmer.faculty = "Computer Systems and Networks";
            programmer.speciality = "Programming Engineer";
            programmer.studentPrintInfo();
        }
    }
}
