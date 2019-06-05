using System;

namespace inheritance_practice
{
    public class Cessna : Vehicle
    {  // Propellor light aircraft
        public double FuelCapacity { get; set; }
        public void RefuelTank () 
        {
            Console.WriteLine($"Gassin' up the tank in the {this.MainColor} {this.GetType().Name}");
        }

        // Override the Drive() method in all the other vehicle classes. Include the vehicle's color in the message (i.e. "The blue Ram drives past. RRrrrrrummbbble!")
        public override string Drive()
        {
            return $"{base.Drive()} Vroooooom!";
        }
    }
}