using System;
using System.Collections.Generic;

namespace inheritance_practice
{
    public class GasStation : Station, IStation<Vehicle> 
    {
        public int Capacity {get; set;}

        // public void Refuel(List<Vehicle> gasVehicles)
        // {
        //     foreach(Vehicle car in gasVehicles)
        //     {
        //        Console.WriteLine($"The {car.GetType().Name} has been refueled"); 
        //     }
            
        // }
    }
}