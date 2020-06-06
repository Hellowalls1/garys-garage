using System;

namespace Garys_Garage {
    public class Vehicle {

        //these are all shared by the individual classes so they are located here and called after the individual classname with (: Vehicle)
        //are can be called into interpolated strings
        //are utilized in instances of objects
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        //virtual void means inherited methods can be overidden by children 
        public virtual void Drive () {

            Console.WriteLine ("Vroom!");
        }

        public virtual void Stop () {
            Console.WriteLine ("The vehicle gently rolls to a stop.");
        }

        //this method is being called on program. It needs to be passed an argument in quotations (string)
        public virtual void Turn (string direction) {
            Console.WriteLine ($"The vehicle carefully turns {direction}");

        }
    }

}