using System;
using System.Collections.Generic;

namespace inheritance_practice
{
    public class Station
    {
        public void Refuel(List<Vehicle> vehicles)
        {
            foreach(Vehicle car in vehicles)
            {
                Console.WriteLine($"The {car.GetType().Name} is being refueled");
            }
        }
    }
}