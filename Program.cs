using Intersection;

namespace Program
{
    class Program
    {
        public static void Main()
        {
            bool withTrafficLights = true;
            // Main loop
            while (true)
            {
                int nbrRoads = new Random().Next(2, 4);
                Intersection.Intersection intersection = new(nbrRoads, withTrafficLights);
                Console.WriteLine(intersection);
                // Loop through each road
                foreach (Road road in intersection.ListRoads)
                {
                    // Loop through each car in road
                    foreach (Vehicle.Vehicle vehicle in road.ListVehicle)
                    {
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();

                        vehicle.Go();
                        road.ListVehicle.Remove(vehicle);
                    }
                }
            }
        }
    }
}