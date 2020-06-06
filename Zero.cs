using System;

namespace Garys_Garage {
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery () {
            // method definition omitted
        }

        public override void Drive () {
            Console.WriteLine ($"The {MainColor} scooter scoots by. PPPPYEEEEEEERRRRR!");
        }

        public override void Stop () {
            Console.WriteLine ($"The {MainColor} scooter refused to stop and flew off of a trailer ramp into a construction site.");
        }
    }
}