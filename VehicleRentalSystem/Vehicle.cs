using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    public abstract class Vehicle
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public decimal Value { get; set; }
        public decimal rentalCost { get; set; }
        public decimal rentalCostLonger { get; set; }
        public double InsuranceCost { get; set; }
        public int SafetyRating { get; set; }

        public abstract decimal GetInsurenceCost(User user);

    }
}
