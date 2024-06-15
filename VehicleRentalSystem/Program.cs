using System;

namespace VehicleRentalSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("S16", "Mercedes", 15000, 3);
            User u = new User("John", "Doe", 25, 4);
            DateTime start = new DateTime(2024, 6, 3);
            DateTime end = new DateTime(2024, 6, 13);
            DateTime real = new DateTime(2024, 6, 13);
            Renting r = new Renting(u, c, start, end, real);
            r.PrintRetingInformation();

            Motorcycle m = new Motorcycle("CBR1000RR", "Honda", 10000, 3);
            User u2 = new User("Mary", "Johanson", 20, 3);
            Renting r2= new Renting(u2,m, start, end, real);
            r2.PrintRetingInformation();

            CargoVan v = new CargoVan("Citroen", "Jumper", 20000, 4);
            User u3 = new User("Jack", "Miller", 36, 8);
            DateTime rel2 = new DateTime(2024, 6, 13);
            DateTime end2 = new DateTime(2024, 6, 18);
            Renting r3= new Renting(u3,v, start, end2, rel2);
            r3.PrintRetingInformation();
            
        }
    }
}

