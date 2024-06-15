using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    public class CargoVan:Vehicle
    {
        public CargoVan(string model, string brand, decimal value, int safetyrating)
        {
            this.Model = model;
            this.Brand = brand;
            this.Value = value;
            this.SafetyRating = safetyrating;
            this.rentalCost = 50;
            this.rentalCostLonger = 40;
            this.InsuranceCost = 0.03;
        }

        public override decimal GetInsurenceCost(User user)
        {
            decimal d = (this.Value * (decimal)InsuranceCost)/100;
            
            if (user.DriverExperience>5)
                d = d * (decimal)0.85;
            return d;
        }
    }
}

