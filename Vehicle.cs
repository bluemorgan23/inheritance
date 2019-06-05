using System;

namespace inheritance_practice
{
    public class Vehicle
    {
        // protected string _name;

        // public Vehicle(string name){
        //     _name = name;
        // }
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        // Create a Drive() method in the Vehicle class.
        public virtual string Drive () {
           return $"The {this.MainColor} {this.GetType().Name} drives past.";
        }

        // Create a Turn(string direction) mathod, and a Stop() method on Vehicle. Define a basic implementation of each.

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The {this.MainColor} {this.GetType().Name} is making a right turn!");
        }

        public virtual void Stop()
        {
            Console.WriteLine($"Skrrrrt! The {this.MainColor} {this.GetType().Name} is stopping!");
        }

        // public virtual void OilChange() {
        //     Console.WriteLine($"Oil Change on {_name}");
        // }
    }
}