using System;

namespace Garys_Garage {
    class Program {
        static void Main (string[] args) {

            Zero fxs = new Zero ();
            Tesla x26 = new Tesla ();

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

            //inherits from the drive method from baseclass vehicle
            truck.Drive ();
            fxs.Drive ();
            x26.Drive ();
            plane.Drive ();
            truck.Drive ();
        }
    }
}