using System;
using System.Collections.Generic;
using System.Text;

namespace laba3
{
    class Figure
    {
        private int _angles;
        private double _area;
        private double _perimetr;
        private double _sidelenght;
        private double _radius;
        private bool _ontheflat;
        private string[] _planecolor =new string[2];
        
        public Figure(int sidelenght, bool ontheflat)
        {
            _sidelenght = sidelenght;
            _ontheflat = ontheflat;
        }

        public Figure(int angles, int sidelenght, bool ontheflat) 
        {
            _angles = angles;
            _radius = sidelenght / (2 * Math.Sin(Math.PI / (angles = angles != 0 ? angles : 1)));
            _sidelenght = sidelenght;
            _ontheflat = ontheflat;
        }

        public Figure(double radius, int angles)
        {
            _radius = radius;
            _angles = angles;
            _sidelenght = radius * (2 * Math.Sin(Math.PI / (_angles = _angles != 0 ? _angles : 1)));
        }

        public Figure(double perimeter, int angles, bool ontheflat)
        {
            _perimetr = perimeter;
            _ontheflat = ontheflat;
            _angles = angles;
            _sidelenght = perimeter / angles;
        }

        //----------------------------
        public int Angles
        {
            get
            {
                return _angles;
            }
            set
            {
                if (value < 3) _angles = 3;
                else _angles = value;
            }
        }
       
        public double Area
        {
            get
            {
                return _area;
            }
        }

        public double Perimeter
        {
            get
            {
                _perimetr= _sidelenght * _angles; 
                return _sidelenght * _angles;
            }
        }

        public double Side
        {
            get
            {
                return _sidelenght;
            }
            set
            {
                if (value < 1) _sidelenght = 1;
                else _sidelenght = value;
            }
        }

        //-------------------------------------------
        public string this[int index]
        {
            get 
            {
                return _planecolor[index];
            }
            set
            {
                _planecolor[index] = value;
            }
        }

        //----------------------------------------
        public double GetRadius()
        {
            _radius = _sidelenght / (2 * Math.Sin(Math.PI / (_angles = _angles != 0 ? _angles : 1)));
            return Math.Round(_radius,3);
        }

        public double GetAreaS()
        {
            if (_angles == 4)
            _area = _sidelenght * _sidelenght;          
            _area = 0.5 * Math.Pow(_radius, 2) * _angles * Math.Sin(2*Math.PI / (_angles = _angles != 0 ? _angles : 1));
            return _area;
        }

        public void Initialfigure()
        {
            Console.Write("Количество углов:");
            while (!Int32.TryParse(Console.ReadLine(), out _angles))
                Console.WriteLine("Введите корректное значение");
            Console.Write("Длину стороны:");
            while (!Double.TryParse(Console.ReadLine(), out _sidelenght))
                Console.WriteLine("Введите корректное значение");
            Console.WriteLine("Цвет фигуры сверху/сниизу:");
            _planecolor[0] = Console.ReadLine();
            _planecolor[1] = Console.ReadLine();
        }

        public void InfoofFigure()
        {
            if (_ontheflat)
            {
                Console.WriteLine("Фигура плоская");
                Console.WriteLine("Правильный {0}-угольник", _angles);
            }
            Console.WriteLine("Фигура объёмная");
            Console.WriteLine("Кол-во углов:" + _angles);
            Console.WriteLine("Длина сторорны:" + _sidelenght);
            Console.WriteLine("Периметр:" + _perimetr);
            Console.WriteLine("Площадь:" + _area);
            Console.WriteLine("Радиус описанной окружности:" + _radius);
            Console.WriteLine($"Цвет сверху: {_planecolor[0]}\nЦвет снизу:{_planecolor[1]}");
        }

        public void Change()
        {
            int change;           
            Console.WriteLine("(1)Кол-во углов");
            Console.WriteLine("(2)Длина стороны");
            Console.WriteLine("(3)Цвет фигуры сверху/снизу");
            while (!Int32.TryParse(Console.ReadLine(), out change) || change < 1 || change >3)
            {
                Console.Clear();
                Console.WriteLine("Введите число:");               
            }
            Console.Clear();
            switch(change)
            {
                case 1:
                    {
                        _angles = Int32.Parse(Console.ReadLine());
                        break;
                    }
                case 2:
                    {
                        _sidelenght = Int32.Parse(Console.ReadLine());
                        break;
                    }
                case 3:
                    {
                        _planecolor[0] = Console.ReadLine();
                        _planecolor[1] = Console.ReadLine();
                        break;
                    }               
            }
        }
    }
}
