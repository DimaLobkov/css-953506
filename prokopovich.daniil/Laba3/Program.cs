using System;

namespace Chelovek
{
    class Program
    {
        static void Main()
        {
            char selection;
            string name = "", surname = "", status ="", gender = "";
            int birth_year = 0;
            Human human;

            Console.WriteLine("Enter name and surname");
            name = Console.ReadLine();
            surname = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter status (student/worker or other)");
            status = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter gender (male/female, other - skip)");
            gender = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter birth year");
            int.TryParse(Console.ReadLine(), out birth_year);

            if (birth_year < 1900 || birth_year > 2020)
                birth_year = 2020;
            Console.Clear();

            Human.birth_year = birth_year;
            human = new Human(name, surname, status, gender);

            do
            {
                Console.WriteLine("1 - Show info\n2 - Sleep\n3 - Change name\n4 - Change surname\n5 - Set illness\n6 - Sing\n7 - Change gender\n8 - Show name and surname\n9 - Show status\nq - Exit");
                selection = Console.ReadKey().KeyChar;
                Console.Clear();

                switch (selection)
                {
                    case '1':
                        human.ShowInfo();
                        Console.ReadKey();
                        break;
                    case '2':
                        if (human.isSleep)
                            human.Awakening();
                        else human.Sleep();
                        break;
                    case '3':
                        Console.Write("name - ");
                        human.Name = Console.ReadLine();
                        break;
                    case '4':
                        Console.Write("surname - ");
                        human.Surname = Console.ReadLine();
                        break;
                    case '5':
                        Console.Write("illness - ");
                        human.Illness = Console.ReadLine();
                        break;
                    case '6':
                        human.Sing();
                        break;
                    case '7':
                        human.ChangeGender();
                        break;
                    case '8':
                        Console.Clear();
                        Console.Write(human["name"] + " " + human["surname"]);
                        Console.ReadKey();
                        break;
                    case '9':
                        Console.Clear();
                        Console.Write(human["name"] + " " + human["surname"] + " is a " + human["status"]);
                        Console.ReadKey();
                        break;
                    case 'q':
                        return;
                }
                Console.Clear();
            } while (true);
        }
    }
}
