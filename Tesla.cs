using System;

namespace inheritance_practice
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery() { 
            Console.WriteLine($"Charging the battery in the {this.MainColor} {this.GetType().Name}");
        }

        // public Tesla(string name):base() {}

        // Override the Drive() method in all the other vehicle classes. Include the vehicle's color in the message (i.e. "The blue Ram drives past. RRrrrrrummbbble!")
        public override string Drive() {
            
            return ($"{base.Drive()} Zooooom");
        }

        // public override void OilChange() {
        //     Console.WriteLine("Tesla Oil Change...");
        // }
    }
}