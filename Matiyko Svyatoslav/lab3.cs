// Предусмотреть набор методов, полей, свойств, конструкторов и индексато-ров в реализуемом классе. 
// Реализовать статические элементы класса (например, создание уникального Id), перегрузку методов
//	#Человек – Студент – Студенты отдельных специальностей#

using System;

namespace _3
{
    class People 
    {
        public string Name{get; set;}
        protected int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(age>=0)
                {
                    age = value;
                }
            }
        }
    }

    class Student : People
    {
        string work_status;
        string university;
        int  course;
        bool stud_status;

        public int Course
        {
            get
            {
                return course;
            }
            set
            {
                if(value>=1 && value<=4)
                {
                    course = value;
                }
            }
        }
        
        public bool University()
        {
            Console.WriteLine("1.БГУИР\n2.БГУ\n3.БНТУ\n4.Другой университет\n5.Не являюсь студентом");
            int a = int.Parse(Console.ReadLine());
            
            switch(a)
            {
                case 1:
                    university = "БГУИР";
                    break;

                case 2:
                    university = "БГУ";
                    break;

                case 3:
                    university = "БНТУ";
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Введите название вашего университета: ");
                    university = Console.ReadLine();
                    break;

                case 5:
                {
                    university = "Не является студентом";
                    stud_status = true;
                    break;
                }
            }

            if(stud_status)   
            {  
                return stud_status;
            }
            else 
            {
                return false;
            }
        }

        public void Work_status()
        {
            Console.WriteLine("Есть ли у вас работа: да/нет");
            string T_or_F = Console.ReadLine();

            if(T_or_F == "да")
            {
                work_status = "имеет работу";
            }
            else
            {
                work_status = "без работы";
            }
        }
        
        public void Inforamation_about_student()
        {
            Console.Clear();

            if(stud_status)
            {
                Console.WriteLine("имя: {0}\nВозраст: {1}\nМесто учебы: {2}\n", Name, age, university);
            }
            else
            {
                Console.WriteLine("имя: {0}\nВозраст: {1}\nМесто учебы: {2}\n№ курса: {3}\nwork_status: {4}", Name, age, university, course, work_status);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            
            Console.WriteLine("Введите Имя: ");
            st1.Name = Console.ReadLine();

            Console.WriteLine("\nВведите возраст: ");
            st1.Age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("\nВ каком университете вы учитесь?: ");
            bool check = st1.University();
            
            if(!check)
            {
            Console.WriteLine("\nНа каком курсе обучения вы находитесь?");
            st1.Course = int.Parse(Console.ReadLine());
            st1.Work_status();
            }    

            st1.Inforamation_about_student();
            Console.ReadLine();
        }
    }
}
