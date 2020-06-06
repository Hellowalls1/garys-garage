﻿using System;

namespace Garys_Garage {
    class Program {
        static void Main (string[] args) {

            //instances of classes

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

            //inherits from the drive method from baseclass vehicle. Added a requirement to "Turn" to need an argument
            truck.Drive ();
            truck.Turn ("left");
            truck.Stop ();
            Console.WriteLine ();
            car.Drive ();
            car.Stop ();
            car.Turn ("left");
            Console.WriteLine ();
            plane.Drive ();
            plane.Turn ("right");
            plane.Stop ();
            Console.WriteLine ();
            scooter.Drive ();
            scooter.Turn ("left");
            scooter.Stop ();
        }
    }
}