using System;
using System.Collections.Generic;

namespace inheritance_practice
{
    public class BatteryStation : Station, IStation<Vehicle>
    {
        public int Capacity {get; set;}

        // public void Refuel(List<Vehicle> electricVehicles)
        // {
        //     foreach(Vehicle car in electricVehicles)
        //     {
        //         Console.WriteLine($"The {car.GetType().Name} is being refuelled");
        //     }
        // }
    }
}