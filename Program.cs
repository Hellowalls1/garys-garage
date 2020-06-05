using System;

namespace Garys_Garage {
    class Program {
        static void Main (string[] args) {

            Cessna plane = new Cessna () {
                MainColor = "blue",
                MaximumOccupancy = "6",
                FuelCapacity = 22.2
            };

            Ram truck = new Ram () {
                MainColor = "Red",
                MaximumOccupancy = "20",
                FuelCapacity = 40.5,

            };
            Zero scooter = new Zero () {
                MainColor = "Red",
                MaximumOccupancy = "20",
                BatteryKWh = 40.5

            };
            Tesla car = new Tesla () {
                MainColor = "Red",
                MaximumOccupancy = "20",
                BatteryKWh = 2.3
            };

            //inherits from the drive method from baseclass vehicle
            truck.Drive ();
            car.Stop ();
            plane.Drive ();
            car.Stop ();
            scooter.Drive ();
            car.Stop ();
            car.Drive ();
            car.Stop ();
        }
    }
}