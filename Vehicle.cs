using Intersection; // Importing Intersection namespace to access the Road class

namespace Vehicle
{
    public class Vehicle : IVehicle
    {
        // Properties of the Vehicle class
        public Road StartingPoint { get; set; } // Starting point of the vehicle
        public Road DestinationPoint { get; set; } // Destination point of the vehicle
        public Road CurrentPoint { get; set; } // Current point of the vehicle
        public ListBrands Brand { get; set; } // Brand of the vehicle
        public ListVehicle TypeVehicle { get; set; } // Type of vehicle
        public string HonkSong { get; set; } // Sound made when honking
        public int Speed { get; set; } // Speed of the vehicle

        // Constructor for the Vehicle class
        public Vehicle(ListBrands brand, int speed, string honkSong, Road startingPoint, Road destinationPoint, ListVehicle typeVehicle)
        {
            StartingPoint = startingPoint;
            DestinationPoint = destinationPoint;
            CurrentPoint = startingPoint;
            Brand = brand;
            TypeVehicle = typeVehicle;
            HonkSong = honkSong;
            Speed = speed;
        }

        // Method for the vehicle to move towards its destination
        public void Go()
        {
            Console.WriteLine(string.Format("The {0} is moving to road {1}\n", TypeVehicle, DestinationPoint.RoadName));
            CurrentPoint = DestinationPoint;
        }

        // Method to stop the vehicle
        public void Stop()
        {
            Console.WriteLine("The vehicle has stopped");
        }

        // Method to make the vehicle honk
        public void Honk()
        {
            Console.WriteLine(HonkSong);
        }

        // Override of ToString method to display vehicle details
        public override string ToString()
        {
            return string.Format("Vehicle :\n*  {0}\n*  {1}\n*  {2}\n*  Start at road {3}\n*  Wants to go to road {4}\n\n",TypeVehicle, Brand, Speed, StartingPoint.RoadName, DestinationPoint.RoadName);
        }
    }
}
