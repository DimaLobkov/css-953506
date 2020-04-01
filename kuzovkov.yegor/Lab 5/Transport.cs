using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Lab_5_Ind_1
{
    abstract class Transport
    {
        //fields
        protected static int _seriesNumber;
        protected string _name;
        protected string _color;
        protected string _comfortLevel;
        protected uint _yearMade;

        //properties
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Color
        {
            get => _color;
            set => _color = value;
        }

        public string ComfortLevel
        {
            get => _comfortLevel;
            set => _comfortLevel = value;
        }

        public uint YearMade
        {
            get => _yearMade;
            set
            {
                if (value > 2020 || value < 1960)
                    return;
                else
                    _yearMade = value;
            }
        }

        public static int Series
        {
            get => _seriesNumber;
        }

        //constructors
        public Transport(string name, string color, string comfort, uint year)
        {
            _name = Name;
            _color = Color;
            _comfortLevel = comfort;
            _yearMade = year;

        }

        public Transport()
        {
            _name = "NULL";
            _color = "NULL";
            _comfortLevel = "NULL";
            _yearMade = 0;
        }

        //destructor
        ~Transport() { }

        //methods
        public static void Beep()
        {
            Console.WriteLine("Beep!\a");
        }

        public static void SetSeries()
        {
            Random rnd = new Random();
            _seriesNumber = rnd.Next(1000, 10000);
        }
    }
}
