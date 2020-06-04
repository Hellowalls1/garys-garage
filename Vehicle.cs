using System;

namespace Garys_Garage {
    public class Vehicle {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        //virtual void means inherited methods can be overidden by children 
        public virtual void Drive () {
            Console.WriteLine ("Vroom!");
        }
    }

}