using System;

namespace Lab3
{
    class Human
    {
        private static int PersonalIdCounter;

        private int _personalId;
        private string _firstname;
        private string _lastname;
        private DateTime _birthdate;
        private Sex _sex;
        private int _height;
        private int _weight;

        public Human(string firstname, string lastname, Sex sex, int height, int weight)
        {
            _firstname = firstname;
            _lastname = lastname;
            _birthdate = DateTime.Now;
            _sex = sex;
            _height = height;
            _weight = weight;

            _personalId = PersonalIdCounter++;
        }

        public Human(string firstname, string lastname, DateTime birthdate, Sex sex, int height, int weight) : this(firstname, lastname, sex, height, weight)
        {
            _birthdate = birthdate;
        }

        public string this[string property]
        {
            get
            {
                switch (property)
                {
                    case "Firstname":
                        return _firstname;
                    case "Lastname":
                        return _lastname;
                    default:
                        return string.Empty; // ""
                }
            }
            set
            {
                switch (property)
                {
                    case "Firstname":
                        _firstname = value; break;
                    case "Lastname":
                        _lastname = value; break;
                }
            }
        }

        public int PersonalId
        {
            get
            {
                return _personalId;
            }
        }

        public string Firstname
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
            }
        }

        public DateTime Birthdate
        {
            get
            {
                return _birthdate;
            }
            private set
            {
                _birthdate = value;
            }
        }

        public Sex Sex
        {
            get
            {
                return _sex;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public int Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
            }
        }

        public int GetFullYears()
        {
            var zeroTime = new DateTime(1, 1, 1);
            var difference = DateTime.Now - _birthdate;
            var years = (zeroTime + difference).Year - 1;

            return years;
        }

        public double GetBodyMassIndex()
        {
            var bmi = _weight / Math.Pow(_height / 100D, 2);

            return bmi;
        }

        public void AddWeight()
        {
            _weight++;
        }

        public void AddWeight(int additionalWeight)
        {
            _weight += additionalWeight;
        }

        public override string ToString()
        {
            return $"Personal ID: {_personalId};" + Environment.NewLine +
                $"Name: {_firstname}, {_lastname};" + Environment.NewLine +
                $"Birthdate: {_birthdate.ToShortDateString()}" + Environment.NewLine +
                $"Sex: {_sex};" + Environment.NewLine +
                $"Height: {_height} cm;" + Environment.NewLine +
                $"Weight: {_weight} kg.";
        }
    }
}
