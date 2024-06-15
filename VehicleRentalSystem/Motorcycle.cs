using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    public class Motorcycle:Vehicle
    {
        public Motorcycle(string model, string brand, decimal value, int safetyrating)
        {
            this.Model = model;
            this.Brand = brand;
            this.Value = value;
            this.SafetyRating = safetyrating;
            this.rentalCost = 15;
            this.rentalCostLonger = 10;
            this.InsuranceCost = 0.02;
        }

        public override decimal GetInsurenceCost(User user)
        {
            decimal d = (this.Value * (decimal)InsuranceCost)/100;
    
            if (user.Age<25)
                d = d * (decimal)1.2;
            return d;
        }
    }
}

