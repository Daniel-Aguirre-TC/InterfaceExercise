using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Suv : Vehicle
    {
        public enum SuvTypes { Crossover, Mini, Compact, Midsize, Fullsize, ExtendedLength  }
        public int MaxPassengers { get; set; }
        public SuvTypes SuvType { get; set; }

        public Suv(string name, int numberOfWheels, string logo, string motto, int maxPassenger, SuvTypes suvType) : base(name, numberOfWheels, logo, motto)
        {
            MaxPassengers = maxPassenger;
            SuvType = suvType;
            InterpolateVehicleInfo();
        }

        public override void InterpolateVehicleInfo()
        {
            base.InterpolateVehicleInfo();
            Console.WriteLine($" • Maximum Passengers: {MaxPassengers}\n • SUV Type: {SuvType}");           

        }

    }
}
