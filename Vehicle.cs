using Intersection;

namespace Vehicle
{
    public class Vehicle(ListBrands brand, int speed,string honkSong, Road startingPoint, Road destinationPoint, ListVehicle typeVehicle) : IVehicle
    {
        public Road StartingPoint { get; set; } = startingPoint;
        public Road DestinationPoint { get; set; } = destinationPoint;
        public ListBrands Brand { get; set; } = brand;
        public ListVehicle TypeVehicle {get; set; } = typeVehicle;
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
            return string.Format("Vehicle :\n{0}\n{1}\n{2}\nStart at road {3}\nWants to go to road {4}\n", TypeVehicle, Brand, Speed, StartingPoint.RoadName, DestinationPoint.RoadName);
        }
    }
}