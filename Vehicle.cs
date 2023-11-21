using Intersection;

namespace Vehicle
{
    public class Vehicle : IVehicle
    {
        public Road StartingPoint { get; set; }
        public Road DestinationPoint { get; set; }
        public Road CurrentPoint { get; set; }
        public ListBrands Brand { get; set; }
        public ListVehicle TypeVehicle {get; set; }
        public string HonkSong { get; set; }
        public int Speed { get; set; }

        public Vehicle(ListBrands brand, int speed,string honkSong, Road startingPoint, Road destinationPoint, ListVehicle typeVehicle)
        {
            StartingPoint = startingPoint;
            DestinationPoint = destinationPoint;
            CurrentPoint = startingPoint;
            Brand = brand;
            TypeVehicle = typeVehicle;
            HonkSong = honkSong;
            Speed = speed;
        }

        public void Go()
        {
            Console.WriteLine("The Vehicle is goigng to the destination road");
            CurrentPoint = DestinationPoint;
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
            return string.Format("Vehicle :\n{0}\n{1}\n{2}\nStart at road {3}\nWants to go to road {4}\n", TypeVehicle, Brand, Speed, StartingPoint.RoadName, DestinationPoint.RoadName);
        }
    }
}