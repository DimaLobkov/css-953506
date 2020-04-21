using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Person
    {
        public string _name;        // имя
        public string _student;     // является ли студентом
        public string _speciality;  // специальность 
        private int _id;            // id студента  
        private static int id = 0;
        

        public Person() {
            _name = "Неизвестно";
            _student = "Неизвестно";
            _speciality = "Неизвестно";
            _id = id;
            id++;
        }
        public Person(string name) {
            _name = name ;
            _student = "Неизвестно";
            _speciality = "Неизвестно";
            _id = id;
            id++;
        }
        public Person(string name, string student) {
            _name = name;
            _student = student;
            _speciality = "Неизвестно";
            _id = id;
            id++;
        }
        public Person(string name, string student,string spec) {
            _name = name;
            _student = student;
            _speciality = spec;
            _id = id;
            id++;
        }

        public string Name
        {

            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Student
        {

            get
            {
                return _student;
            }
            set
            {
                _student = value;
            }
        }

        public string Speciality
        {

            get
            {
                return _speciality;
            }
            set
            {
                _speciality = value;
            }
        }

        public int ID
        {
            get
            {
                return _id;
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($@"
        Имя: {_name}
        Студент?:{_student}
        Специальность:{_speciality}
        id: {_id}");
        }

        public void SetInfo(string name,string student,string speciality)
        {
            _name = name;
            _student = student;
            _speciality = speciality;
        }

        public void Myself()
        {
            Console.WriteLine("Я");
            _name       = "Шавель Ян";
            _student    ="Да";
            _speciality = "ИиТП";
        }

        public string this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return _name;
                    case 1: return _student;
                    case 2: return _speciality;
                    default: return "null";
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Myself();
            person.GetInfo();
            Console.ReadLine();
        }
    }
}
