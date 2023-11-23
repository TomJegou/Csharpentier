using Intersection;

namespace Program
{
    class Program
    {
        public static void Main()
        {
            while (true)
            {
                Intersection.Intersection intersection = new(2, 0);
                Console.WriteLine(intersection);
                foreach (Road road in intersection.ListRoads)
                {
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