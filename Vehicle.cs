using System;
using System.ComponentModel;

namespace Vehicle
{
    class Vehicle(string brand, string honkSong) : IVehicle
    {
        public string Brand { get; set; } = brand;
        public string HonkSong { get; set; } = honkSong;

        public void Go()
        {
            Console.WriteLine("The Vehicle is going in the intersection");
        }

        public void Stop()
        {
            Console.WriteLine("The vehicle has stopped");
        }

        public void Honk()
        {
            Console.WriteLine(HonkSong);
        }
    }
}