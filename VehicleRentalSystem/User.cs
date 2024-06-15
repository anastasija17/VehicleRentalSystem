using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    public class User
    {
        public string Name { get; set; }
        public string SubName { get; set; }
        public int Age { get; set; }
        public int DriverExperience { get; set; }

        public User(string name, string subname, int age, int dexpirience)
        {
            Name = name; 
            SubName = subname; 
            Age = age; 
            DriverExperience = dexpirience; 
        }
    }
}
