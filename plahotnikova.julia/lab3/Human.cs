using System;

namespace Lab3
{
    /// <summary>
    /// Represents human instance
    /// </summary>
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

        /// <summary>
        /// Returns property value by name.
        /// </summary>
        /// <param name="property">Property name</param>
        /// <returns></returns>
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

        /// <summary>
        /// Returns personal generated Id of the human instance.
        /// </summary>
        public int PersonalId
        {
            get
            {
                return _personalId;
            }
        }

        /// <summary>
        /// Returns and sets firstname of the human instance.
        /// </summary>
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

        /// <summary>
        /// Returns and sets lastname of the human instance.
        /// </summary>
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

        /// <summary>
        /// Returns birthdate of the human instance.
        /// </summary>
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

        /// <summary>
        /// Returns sex of the human instance.
        /// </summary>
        public Sex Sex
        {
            get
            {
                return _sex;
            }
        }

        /// <summary>
        /// Returns and sets height of the human instance.
        /// </summary>
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

        /// <summary>
        /// Returns and sets weight of the human instance.
        /// </summary>
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

        /// <summary>
        /// Returns age of the human instance in years.
        /// </summary>
        /// <returns></returns>
        public int GetFullYears()
        {
            var zeroTime = new DateTime(1, 1, 1);
            var difference = DateTime.Now - _birthdate;
            var years = (zeroTime + difference).Year - 1;

            return years;
        }

        /// <summary>
        /// Returns body mass index of the human instance.
        /// </summary>
        /// <returns></returns>
        public double GetBodyMassIndex()
        {
            var bmi = _weight / Math.Pow(_height / 100D, 2);

            return bmi;
        }

        /// <summary>
        /// Adds 1 kg of weigth.
        /// </summary>
        public void AddWeight()
        {
            _weight++;
        }

        /// <summary>
        /// Adds <paramref name="additionalWeight"/> kg of weigth.
        /// </summary>
        /// <param name="additionalWeight">Value of weight to add.</param>
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
