using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    public class Renting
    {
        public User User { get; set; }
        public Vehicle Vehicle { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public Renting(User u, Vehicle v, DateTime sd, DateTime ed, DateTime rd)
        {
            this.User = u;
            this.Vehicle = v;
            this.StartDate = sd;
            this.EndDate = ed;
            this.ReturnDate = rd;
        }


        public void PrintRetingInformation()
        {
            if (this.Vehicle is Car)
            {
                Console.WriteLine("A car that is valued at $" + this.Vehicle.Value + ", and has a secyrity range of " + this.Vehicle.SafetyRating + ":");
            }
            else if(this.Vehicle is Motorcycle)
            {
                Console.WriteLine("A motorcycle that is valued at $" + this.Vehicle.Value + ", and the driver is " + this.User.Age + " years old");
            }
            else
            {
                Console.WriteLine("A cargo van that is valued at $" + this.Vehicle.Value + ", and the driver has  " + this.User.DriverExperience + " years of driving expirienced");
            }
            
                Console.WriteLine("XXXXXXXX");
                Console.WriteLine("Date:" + EndDate.ToShortDateString());
                Console.WriteLine("Costumer Name:" + this.User.Name + " " + this.User.SubName);
                Console.WriteLine("Rented Vehicle:" + this.Vehicle.Brand + " " + this.Vehicle.Model);

                Console.WriteLine("\n");
                Console.WriteLine("Reservation start date:" + this.StartDate.ToShortDateString());
                Console.WriteLine("Reservatin end date:" + this.EndDate.ToShortDateString());
                TimeSpan difference = EndDate - StartDate;
                int days=difference.Days;
                Console.WriteLine("Reserved days: " + days);

                Console.WriteLine("\n");
                Console.WriteLine("Actual return date:" + ReturnDate.ToShortDateString());
                TimeSpan difference2=ReturnDate - StartDate;
                int days2=difference2.Days;
                Console.WriteLine("Actual rental days: " + days2);

                Console.WriteLine("\n");
                decimal rentcost = 0;
                if(days2>7)
                {
                   rentcost = this.Vehicle.rentalCostLonger;
                }
                else
                {
                     rentcost = this.Vehicle.rentalCost;
                }
            Console.WriteLine("Rental cost per day: $" + rentcost);
            if (this.Vehicle is Car)
            {
                decimal insurance = this.Vehicle.GetInsurenceCost(this.User);
                Console.WriteLine("Insurance per day: $ " + insurance);
                Console.WriteLine("\n");
                decimal totalrent = 0;
                decimal totalinsurance = 0;
                if (days2 == days)
                {
                    totalrent = rentcost * days;
                    totalinsurance = days * insurance;
                }
                else
                {
                    totalrent= (rentcost * days)-(rentcost*(days-days2)/2);
                    totalinsurance=days2* insurance;
                }
                   
                    Console.WriteLine("Total rent: $" + totalrent);
                    Console.WriteLine("Total insurance: $" + totalinsurance);
                    decimal total = totalinsurance + totalrent;
                    Console.WriteLine("Total: $" + total);
              
                Console.WriteLine("XXXXXXXXXX");
                Console.WriteLine("\n");
            }
            else if (this.Vehicle is Motorcycle)
            {
                decimal insurance = this.Vehicle.GetInsurenceCost(this.User);
                decimal initial = ((decimal)Vehicle.InsuranceCost * Vehicle.Value) / 100;
                Console.WriteLine("Initial insurance per day: $" + initial);
                decimal addition = insurance - initial;
                Console.WriteLine("Insurance addition per day: $" + addition);
                Console.WriteLine("Insurance per day: $" + insurance);
                decimal totalrent = 0;
                decimal totalinsurance = 0;
                if (days == days2)
                {
                    totalrent = rentcost * days;
                    totalinsurance = days * insurance;
                }
                else
                {
                    totalrent = (rentcost * days) - (rentcost * (days - days2) / 2);
                    totalinsurance = days2 * insurance;
                }
                Console.WriteLine("Total rent: $" + totalrent);
                Console.WriteLine("Total insurance: $" + totalinsurance);
                decimal total = totalinsurance + totalrent;
                Console.WriteLine("Total: $" + total);
                Console.WriteLine("XXXXXXXXXX");
                Console.WriteLine("\n");
            }
            else
            {
                decimal insurance = this.Vehicle.GetInsurenceCost(this.User);
                decimal initial = ((decimal)Vehicle.InsuranceCost * Vehicle.Value)/100;
                Console.WriteLine("Initial insurance per day: $" + initial);
                decimal discount = initial - insurance;
                Console.WriteLine("Insurance discount per day: $" + discount);
                Console.WriteLine("Insurance per day: $" + insurance);

                Console.WriteLine("\n");
                decimal discrent = rentcost * (days - days2)/2;
                decimal discensurance=insurance*(days-days2);
                Console.WriteLine("Erlier discount for rent: $" + discrent);
                Console.Write("Erlier discount for insurence: $" + discensurance);

                decimal totalRent = rentcost * days2;
                decimal totalInsc = insurance * days2;
                Console.WriteLine("\n");
                Console.WriteLine("Total rent: $" + totalRent);
                Console.WriteLine("Total insurence: $" + totalInsc);
                decimal total = totalRent + totalInsc;
                Console.WriteLine("Total: $"+ total);
                Console.WriteLine("XXXXXXXXXX");
            }
               

        }

    }
}
