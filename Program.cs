using Intersection;

namespace Program
{
    class Program
    {
        public static void Main()
        {
            // Main loop
            while (true)
            {
                Intersection.Intersection intersection = new(2, 0, true);
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