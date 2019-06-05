using System;

namespace inheritance_practice
{
    public class Zero : Vehicle
    {  // Electric motorcycle
        public double BatteryKWh { get; set; }

        // Override the Drive() method in all the other vehicle classes. Include the vehicle's color in the message (i.e. "The blue Ram drives past. RRrrrrrummbbble!")
        public override string Drive()
        {
            return $"{base.Drive()} SSSuuuuhhhhhhhh";
        }
        public void ChargeBattery() { 
            Console.WriteLine($"Charging the battery in the {this.MainColor} {this.GetType().Name}");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Zero is making a {direction} turn!");
        }

        public override void Stop()
        {
            Console.WriteLine("The vehicle is coming to a halt! Hold on tight!");
        }
    }
}