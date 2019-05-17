using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Inheritance
{
    public class WagonR : Car
    {
        private readonly int _carMileage;
        public WagonR(int carMileage)
        {
            this._carMileage = carMileage;
            this._isSedan = false;
            this._noOfSeats = "4";
        }

        public WagonR(bool isSedan, string NoOfSeats) : base()
        {

        }

        public override string GetMileage() => $"{this._carMileage} kmpl";
        
    }
}
