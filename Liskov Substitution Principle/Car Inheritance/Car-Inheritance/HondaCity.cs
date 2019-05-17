using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Inheritance
{
    public class HondaCity : Car
    {
        private readonly int _carMileage;

        public HondaCity(int carMileage)
        {
            this._carMileage = carMileage;
            this._isSedan = true;
            this._noOfSeats = "4";
        }

        public HondaCity(bool isSedan, string noOfSeats) : base()
        {
        }


        public override string GetMileage() => $"{this._carMileage} kmpl";
        
    }
}
