using System;

namespace inheritance_practice
{
    public class Ram : Vehicle
    {  // Gas powered truck
        public double FuelCapacity { get; set; }

        // Override the Drive() method in all the other vehicle classes. Include the vehicle's color in the message (i.e. "The blue Ram drives past. RRrrrrrummbbble!")
        public override string Drive()
        {
            return $"{base.Drive()} Ruuuuummmmbleeeerrrrrr!";
        }

        // Override all three of those methods on some of the vehicles. For example, the Stop() method for a plane would be to output the message "The white Cessna rolls to a stop after rolling a mile down the runway."

        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle is turning {direction}! Hold on!");
        }

        public override void Stop()
        {
            Console.WriteLine("The vehicle is stopping! Hold on!");
        }

        public void RefuelTank () 
        {
            Console.WriteLine($"Gassin' up the tank in the {this.MainColor} {this.GetType().Name}");
        }
    }
}