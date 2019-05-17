using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Inheritance
{
    public class InnovaCrysta : Car
    {
        private readonly int _carMileage;

        public InnovaCrysta(int carMileage)
        {
            this._carMileage = carMileage;
            this._isSedan = false;
            this._noOfSeats = "6";
        }

        public InnovaCrysta(bool isSedan, string noOfSeats) : base()
        {
        }


        public override string GetMileage() => $"{this._carMileage} kmpl";
        
    }
}
