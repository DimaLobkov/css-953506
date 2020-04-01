using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Lab_5_Ind_1
{
	 //TODO:
    //1.Most important: add indexers(if possible).
    //2.Add enum CarType.
    class Car : Transport
    {
        //fields
        protected uint price = 0;
        protected uint numberOfSeats;
        protected uint power;
        protected uint trunkSize;

        //properties
        public uint Price
        {
            get => price;
            set => price = value;
        }

        public uint Seats
        {
            get => numberOfSeats;
            set => numberOfSeats = value;
        }

        public uint Power
        {
            get => power;
            set => power = value;
        }

        public uint TrunkSize
        {
            get => trunkSize;
            set => trunkSize = value;
        }

        //constructors
        public Car(uint carPrice, uint carSeats, uint carPower, uint carSize)
        { 
            price = carPrice;
            numberOfSeats = carSeats;
            power = carPower;
            trunkSize = carSize;
        }

        public Car()
        {
            price = 0;
            numberOfSeats = 0;
            power = 0;
            trunkSize = 0;
        }

        //destructor
        ~Car(){}

        //methods
        public void Calculate()
        {
            price = numberOfSeats * 2000 + power * 2;
            if (ComfortLevel == "high")
                price *= 3;
            else if (ComfortLevel == "medium")
                price *= 2;
        }
    }
}
