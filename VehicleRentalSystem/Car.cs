using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    public  class Car:Vehicle
    {
        public Car(string model, string brand, decimal value,int safetyrating)
        {
            this.Model = model;
            this.Brand = brand;
            this.Value = value;
            this.SafetyRating = safetyrating;
            this.rentalCost = 20;
            this.rentalCostLonger = 15;
            this.InsuranceCost = 0.01;
        }

        public override decimal GetInsurenceCost(User user)
        {
            decimal d = (this.Value* (decimal)InsuranceCost)/100;
            
            if (SafetyRating == 4 || SafetyRating == 5)
                d = d * (decimal)0.9;
            return d;
        }
    }
}

