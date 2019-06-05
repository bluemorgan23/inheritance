using System;

namespace inheritance_practice
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create an instance of each vehicle
            Ram newRam = new Ram() 
            {
                MainColor = "Blue",
                FuelCapacity = 17.1,
                MaximumOccupancy = "10"
            };

            Zero newZero = new Zero()
            {
                MainColor = "Red",
                BatteryKWh = 426.19,
                MaximumOccupancy = "3"
            };

            Tesla coolCar = new Tesla()
            {
                MainColor = "Black",
                BatteryKWh = 12.0,
                MaximumOccupancy = "6"
            };

            Cessna coolerCar = new Cessna()
            {
                MainColor = "Green",
                FuelCapacity = 13.9,
                MaximumOccupancy = "55"
            };

            Console.WriteLine(coolCar.Drive());
            coolCar.Turn("right");
            coolCar.Stop();

            Console.WriteLine("- - - - - - - -");

            Console.WriteLine(newZero.Drive());
            newZero.Turn("slight right");
            newZero.Stop();

            Console.WriteLine("- - - - - - - -");

            Console.WriteLine(newRam.Drive());
            newRam.Turn("left");
            newRam.Stop();

            Console.WriteLine("- - - - - - - -");

            Console.WriteLine(coolerCar.Drive());
            coolerCar.Turn("left");
            coolerCar.Stop();
        }
    }
}
