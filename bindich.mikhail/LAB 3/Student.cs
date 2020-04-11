using System;

namespace _3
{
    public class Student : Human
    {
        public int course;
        public string faculty;
        public string speciality;

        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
            course = 0;
            faculty = "";
            speciality = "";
        }

        public float getAverageMark()
        {
            return 0;
        }

        public void studentPrintInfo()
        {
            Console.WriteLine("= = = = = = = = = =\nPerson\n= = = = = = = = = =");
            Console.WriteLine($"First name     || {this.firstName}");
            Console.WriteLine($"Last name      || {this.lastName}");
            Console.WriteLine($"Height         || {this.height}");
            Console.WriteLine($"Weight         || {this.weight}");
            Console.WriteLine($"Course         || {this.course}");
            Console.WriteLine($"Faculty        || {this.faculty}");
            Console.WriteLine($"Speciality     || {this.speciality}");
            Console.WriteLine("= = = = = = = = = =");
        }
    }
}
