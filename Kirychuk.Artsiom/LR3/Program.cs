using System;

namespace laba3
{
    class Program
    {
        static void Main()
        {
            Figure shape = new Figure();
            Menu(shape);
        }

        static void Panel()
        {
            Console.Clear();
            Console.WriteLine("(1)Инициализировать фигуру");
            Console.WriteLine("(2)Площадь");
            Console.WriteLine("(3)Периметр");
            Console.WriteLine("(4)Радиус описанной окружности");
            Console.WriteLine("(5)Информация о фигуре");
            Console.WriteLine("(6)Изменить поле");
        }

        static public void Menu(Figure shape)
        {
            int menu;
            Panel();
            while (!Int32.TryParse(Console.ReadLine(), out menu) || menu < 1 || menu > 6)
            {
                Console.Clear();
                Console.WriteLine("Введите число:");
                Panel();
            }
            switch (menu)
            {
                case 1:
                    {
                        Console.Clear();
                        shape.Initialfigure();
                        Choice(shape);
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        double Area;
                        Area = shape.GetAreaS();
                        Console.WriteLine("Площадь:" + Area);
                        Choice(shape);
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine(shape.Perimetr);
                        Choice(shape);
                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                        double Radius;
                        Radius = shape.GetRadius();
                        Console.WriteLine("Радиус описанной окружности:" + Radius);
                        Choice(shape);
                        break;
                    }
                case 5:
                    {
                        Console.Clear();
                        shape.InfoofFigure();
                        Choice(shape);
                        break;
                    }
                case 6:
                    {
                        Console.Clear();
                        shape.Change();
                        Choice(shape);
                        break;
                    }
            }

            static void Choice(Figure shape)
            {
                int choice;
                Console.WriteLine("Хотите продолжить?");
                Console.WriteLine("(1)ДА\n(0)НЕТ");
                while (!Int32.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 1)
                    Console.WriteLine("Введите корректное значение");
                if (choice == 1) Menu(shape);
                else Environment.Exit(0);
            }        
        }
    }
}
