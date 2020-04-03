using System;
using System.Collections.Generic;
using System.Text;

namespace laba3
{
    class Figure
    {       
        private int _angles;
        private double _area;
        private int _perimetr;
        private int _sidelenght;
        private double _radius;
        private bool _ontheflat;

        //----------------------------
        public Figure() { }

        public Figure(int sidelenght, bool ontheflat) : this()
        {
           _sidelenght = sidelenght;
        }

        public Figure(int angles, int sidelenght, bool ontheflat) : this(sidelenght, ontheflat)
        {
            _angles = angles;
            _radius = sidelenght / 2 /Math.Sin(180 / angles);
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

        public int Perimetr
        {
            get
            {
                _perimetr= _sidelenght * _angles; 
                return _sidelenght * _angles;
            }
        }

        public int Side
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

        //----------------------------------------
        public double GetRadius()
        {
            _radius = _sidelenght / (2 * Math.Sin(Math.PI / (_angles = _angles != 0 ? _angles : 1)));
            return _radius;
        }

        public double GetAreaS()
        {
            _area = 0.5 * Math.Pow(_radius, 2) * _angles * Math.Sin(2*Math.PI / (_angles = _angles != 0 ? _angles : 1));
            return _area;
        }

        public void Initialfigure()
        {
            Console.Write("Количество углов:");
            while (!Int32.TryParse(Console.ReadLine(), out _angles))
                Console.WriteLine("Введите корректное значение");
            Console.Write("Длину стороны:");
            while (!Int32.TryParse(Console.ReadLine(), out _sidelenght))
                Console.WriteLine("Введите корректное значение");
            Console.Write("Плоская ли фигура?(true/false):");
            while (!bool.TryParse(Console.ReadLine(), out _ontheflat))
                Console.WriteLine("Введите корректное значение");
        }

        public void InfoofFigure()
        {
            if (_ontheflat)
            {
                Console.WriteLine("Фигура плоская");
                Console.WriteLine("Правильный {0}-угольник", _angles);
            }
            else Console.WriteLine("Фигура объёмная");
            Console.WriteLine("Кол-во углов:" + _angles);
            Console.WriteLine("Длина сторорны:" + _sidelenght);
            Console.WriteLine("Периметр:" + _perimetr);
            Console.WriteLine("Площадь:" + _area);
            Console.WriteLine("Радиус описанной окружности:" + _radius);
        }

        public void Change()
        {
            int change;           
            Console.WriteLine("(1)Кол-во углов");
            Console.WriteLine("(2)Длина стороны");
            Console.WriteLine("(3)Положение");
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
                        _ontheflat = bool.Parse(Console.ReadLine());
                        break;
                    }
            }
        }
    }
}
