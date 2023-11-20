using System;
using System.ComponentModel;
using Intersection;

namespace Vehicle
{
    public class Vehicle(string brand, int speed,string honkSong, ListDirection startingPoint, ListDirection destinationPoint) : IVehicle
    {
        public ListDirection StartingPoint { get; set; } = startingPoint;
        public ListDirection DestinationPoint { get; set; } = destinationPoint;
        public string Brand { get; set; } = brand;
        public string HonkSong { get; set; } = honkSong;
        public int Speed { get; set; } = speed;

        public void Go()
        {
            Console.WriteLine("The Vehicle is goigng in the intersection");
        }

        public void Stop()
        {
            Console.WriteLine("The vehicle has stopped");
        }

        public void Honk()
        {
            Console.WriteLine(HonkSong);
        }

        public override string ToString()
        {
            return string.Format("Vehicle :\n{0}\n{1}", Brand, Speed);
        }
    }
}