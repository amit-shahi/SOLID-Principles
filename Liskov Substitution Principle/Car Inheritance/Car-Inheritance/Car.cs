using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Car_Inheritance
{
    public abstract class Car
    {
        protected bool _isSedan;
        protected string _noOfSeats;


        public Car()
        {
        }


        public Car(bool isSedan, string noOfSeats)
        {
            this._isSedan = isSedan;
            this._noOfSeats = noOfSeats;
        }

        public bool GetIsSedan()
        {
            return this._isSedan;
        }

        public string GetNoOfSeats()
        {
            return this._noOfSeats;
        }

        // I want all types of Car return their Mileage as per Seats and IsSedan parameter passed from Child class
        abstract public string GetMileage();

        // print method that returns expected output
        // If we let derived class to Print() output, they could mismatch
        // so, it's better to have Print() in this abstract class
        
        public string Print(CarType carType)
        {
            string isSedan = (GetIsSedan() == true) ? "a" : "not a";

            return $"A {carType} is {isSedan} Sedan, is { GetNoOfSeats() } - seater, and has a mileage of around {GetMileage()}.";
        }
    }
}
