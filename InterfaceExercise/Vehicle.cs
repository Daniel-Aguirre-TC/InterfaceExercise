using System;
using System.Collections.Generic;  
using System.Text;

namespace InterfaceExercise
{
    abstract class Vehicle : IVehicle, ICompany
    {

        public int NumberOfWheels { get; set; }
        public string VehicleName { get; set; }
        public string VehicleClass { get; set; }
        public string Logo { get; set; }
        public string Motto { get; set; }

        public Vehicle(string Name, int NumberOfWheels, string logo, string motto)
        {
            this.NumberOfWheels = NumberOfWheels;
            VehicleName = Name;
            VehicleClass = GetType().Name;
            Logo = logo;
            Motto = motto;
        }

        public virtual void InterpolateVehicleInfo()
        {
            Console.WriteLine("\n****************\n");
            Console.WriteLine($" • Vehicle Class: {VehicleClass}\n • Vehicle Name: {VehicleName}\n • Number of Wheels: {NumberOfWheels}\n • Logo: {Logo}\n • Motto: {Motto}");
        }

        public void Drive()
        {
            Console.WriteLine($"You take your {VehicleClass} that you named {VehicleName} out for a drive.");
        }

        public void ReplaceTire()
        {
            Console.WriteLine($"You replace the tires on your {VehicleClass} that you named {VehicleName} out for a drive.");
        }
    }
}
