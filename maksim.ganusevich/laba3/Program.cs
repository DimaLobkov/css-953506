using System;

namespace laba3
{
    class Human
    {
        private enum Gender 
        { 
            male,
            female,
            indefined
        }
        
        public DateTime date_of_death { get; set; }
        public DateTime date_of_birth { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
        public string name { get; set; }
        public String surname { get; set; }
        public string eye_color { get; set; }
        public string hair_color { get; set; }
        public string nationality { get; set; }
        public int id { set; }
        public Gender _gender { get; set; }
        public bool _isLife { get; set; }
        private DateTime _age;
        private static int newID = 0;


        public Human()
        {
            _isLife = false;
            _age = 0;
            date_of_birth();
            height = 0;
            weight = 0;
            name = "-";
            surname = "-";
            eye_color = "-";
            hair_color = "-";
            nationality = "-";
            id = newID;
            newID++;
            date_of_death();
            _gender = Gender.indefined;
        }

        public Human(int day, int month, int year, int height, int weight, string name, string surname, string eye_color, string hair_color, string nationality, int day_of_death, int month_of_death, int year_of_death, Gender gender) 
        {
            this.date_of_birth.Day = day;
            this.date_of_birth.Month = month;
            this.date_of_birth.Year = year;
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.surname = surname;
            this.eye_color = eye_color;
            this.hair_color = hair_color;
            this.nationality = nationality;
            this.date_of_death.Day = day_of_death;
            this.date_of_dea.Month = month_of_death;
            this.date_of_death.Year = year_of_death;
            _gender = gender;
            _age = date_of_death - date_of_birth;
            _isLife = false;
            id = newID;
            newID++;
        }

        public Human(int day, int month, int year, int height, int weight, string name, string surname, string eye_color, string hair_color, string nationality, Gender gender)
        {
            this.date_of_birth.Day = day;
            this.date_of_birth.Month = month;
            this.date_of_birth.Year = year;
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.surname = surname;
            this.eye_color = eye_color;
            this.hair_color = hair_color;
            this.nationality = nationality;
            _age = DateTime.Now - date_of_birth;
            _isLife = true;
            id = newID;
            newID++;
        }

        public int getAge()
        {
            return _age.Year;
        }

        public void getInfo()
        {
            Console.WriteLine(@$"
    Возраст: {Convert.ToString(_age.Year)}
    Дата рождения: {Convert.ToString(date_of_birth)}
    Рост: {Convert.ToString(height)}
    Вес: {Convert.ToString(weight)}
    Имя: {name}
    Фамилия: {surname}
    Цвет глаз: {eye_color}
    Цвет волос:{hair_color}
    Национальность:{nationality}
    id: {id}");
        }

        public void setInfo(int day, int month, int year, int height, int weight, string name, string surname, string eye_color, string hair_color, string nationality, int day_of_death, int month_of_death, int year_of_death)
        {
            this.date_of_birth.Day = day;
            this.date_of_birth.Month = month;
            this.date_of_birth.Year = year;
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.surname = surname;
            this.eye_color = eye_color;
            this.hair_color = hair_color;
            this.nationality = nationality;
            this.date_of_death.Day = day_of_death;
            this.date_of_dea.Month = month_of_death;
            this.date_of_death.Year = year_of_death;
            _age = date_of_death - date_of_birth;
            _isLife = false;
        }

        public void setInfo()
        {

        }

        public void Death(int day_of_death, int month_of_death, int year_of_death) 
        {
            _isLife = false;
            this.date_of_death.Day = day_of_death;
            this.date_of_dea.Month = month_of_death;
            this.date_of_death.Year = year_of_death;
            _age = date_of_death - date_of_birth;
        }


    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human human = new Human();
            human.Age = 10;
            human.setInfo();

        }
    }
}