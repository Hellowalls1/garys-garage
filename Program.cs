using System;
using System.Collections.Generic;
namespace Garys_Garage {
    class Program {
        static void Main (string[] args) {

            Zero fxs = new Zero ();
            Zero fx = new Zero ();
            Tesla modelS = new Tesla ();

            List<IElectric> electricVehicles = new List<IElectric> () {
                fx,
                fxs,
                modelS
            };

            Console.WriteLine ("Electric Vehicles");
            foreach (IElectric ev in electricVehicles) {
                Console.WriteLine ($"{ev.CurrentChargePercentage}");
            }

            foreach (IElectric ev in electricVehicles) {
                // This should charge the vehicle to 100%
                ev.ChargeBattery ();
            }

            foreach (IElectric ev in electricVehicles) {
                Console.WriteLine ($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram ();
            Cessna cessna150 = new Cessna ();

            List<IGas> gasVehicles = new List<IGas> () {
                ram,
                cessna150
            };

            Console.WriteLine ("Gas Vehicles");
            foreach (IGas gv in gasVehicles) {
                Console.WriteLine ($"{gv.CurrentTankPercentage}");
            }

            foreach (IGas gv in gasVehicles) {
                // This should completely refuel the gas tank
                gv.RefuelTank ();
            }

            foreach (IGas gv in gasVehicles) {
                Console.WriteLine ($"{gv.CurrentTankPercentage}");
            }

        }
    }
}
// namespace Garys_Garage {
//     class Program {
//         static void Main (string[] args) {

//             //instances of classes

//             Cessna plane = new Cessna () {
//                 MainColor = "blue",
//                 MaximumOccupancy = "6",
//                 FuelCapacity = 22.2
//             };

//             Ram truck = new Ram () {
//                 MainColor = "Red",
//                 MaximumOccupancy = "20",
//                 FuelCapacity = 40.5,

//             };
//             Zero scooter = new Zero () {
//                 MainColor = "Red",
//                 MaximumOccupancy = "20",
//                 BatteryKWh = 40.5

//             };
//             Tesla car = new Tesla () {
//                 MainColor = "Red",
//                 MaximumOccupancy = "20",
//                 BatteryKWh = 2.3
//             };

//             //inherits from the drive method from baseclass vehicle. Added a requirement to "Turn" to need an argument
//             truck.Drive ();
//             truck.Turn ("left");
//             truck.Stop ();
//             Console.WriteLine ();
//             car.Drive ();
//             car.Stop ();
//             car.Turn ("left");
//             car.ChargeBattery ();
//             Console.WriteLine ();
//             plane.Drive ();
//             plane.Turn ("right");
//             plane.Stop ();
//             Console.WriteLine ();
//             scooter.Drive ();
//             scooter.Turn ("left");
//             scooter.Stop ();
//         }
//     }
// }