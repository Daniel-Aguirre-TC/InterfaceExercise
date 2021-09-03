using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Instructions
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */

            // done

            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            // done

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            // car done
            // suv done
            // truck done


            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            #endregion
            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var carLot = new List<Vehicle>()
            {
                new Car("Audi A5", 4, "Audi", "Vorsprung durch Technik", false, Car.TrunkSizes.Small),
                new Suv("F-Pace", 4, "Jaguar", "The Art of Performance", 5, Suv.SuvTypes.Compact),
                new Truck("F-150", 4, "Ford,", "No More Real Mottos", 10, 2),
                new Car("FakeCar", 6, "Daniel's Logo", "Fake Motto", true, Car.TrunkSizes.Medium),
                new Suv("Fake SUV", 4, "Logo World", "Motto de Motto", 8, Suv.SuvTypes.ExtendedLength),
                new Truck("Fake Truck", 4, "Truck Logo", "Truck Motto", 12, 4)
            };

            Console.WriteLine("\n\nPress any key to show only trucks from my carLot list.");
            Console.ReadKey();

            foreach (var vehicle in carLot)
            {
                if(vehicle is Truck)
                {
                    vehicle.InterpolateVehicleInfo();
                }
            }


        }
    }
}
