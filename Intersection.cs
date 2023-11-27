using Vehicle;
using TrafficLight;

namespace Intersection
{
    public class Intersection : IIntersection
    {
        // Number of roads in the intersection
        public int NbrRoads { get; set; }

        // Number of pedestrians crossing the roads
        public int NbrCrossWalkers { get; set; }

        // List of roads in the intersection
        public List<Road> ListRoads { get; set; } = new();

        // Indicates whether the intersection has traffic lights
        public bool WithTrafficLight { get; set; }

        // Constructor for Intersection class
        public Intersection(int nbrRoads, bool withTrafficLight)
        {
            NbrRoads = nbrRoads;
            WithTrafficLight = withTrafficLight;
            Generate(); // Generates roads and vehicles upon initialization
        }

        // Override of ToString method to display intersection details
        public override string? ToString()
        {
            // Read text from a file to represent intersection details
            string result = File.ReadAllText("assets/Intersection.txt");

            // Concatenate road details to the result
            ListRoads.ForEach(delegate(Road road)
            {
                result += road; // Assumes Road class has overridden ToString method
            });

            return result;
        }

        // Generates roads and vehicles in the intersection
        public void Generate()
        {
            GenerateRoad(); // Create roads
            GenerateVehicles(); // Generate vehicles on the roads
        }

        // Generates vehicles on the roads
        public void GenerateVehicles()
        {
            Random random = new();

            for (int i = 0; i < ListRoads.Count; i++)
            {
                int nbrVehicles = random.Next(0, 3); // Random number of vehicles per road

                for (int j = 0; j < nbrVehicles; j++)
                {
                    // Randomly select start and destination points on roads
                    int startPointIndex = random.Next(0, ListRoads.Count);
                    int destinationPointIndex = random.Next(0, ListRoads.Count);

                    // Check if the indices are within bounds
                    if (startPointIndex < ListRoads.Count && destinationPointIndex < ListRoads.Count)
                    {
                        // Randomly select vehicle brand, type, and speed
                        ListBrands[] brands = (ListBrands[])Enum.GetValues(typeof(ListBrands));
                        ListBrands brand = brands[random.Next(brands.Length)];

                        ListVehicle[] vehicles = (ListVehicle[])Enum.GetValues(typeof(ListVehicle));
                        ListVehicle vehicle = vehicles[random.Next(vehicles.Length)];

                        int[] speedList = IVehicle.GetSpeedList();
                        int speedIndex = random.Next(speedList.Length);
                        int speed = speedList[speedIndex];

                        // Add the generated vehicle to the respective road
                        ListRoads[i].ListVehicle.Add(new Vehicle.Vehicle(brand, speed, "TUUT TUUT !", ListRoads[startPointIndex], ListRoads[destinationPointIndex], vehicle));
                    }
                }
            }
        }

        // Generates roads in the intersection
        public void GenerateRoad()
        {
            for (int i = 0; i < NbrRoads; i++)
            {
                List<Vehicle.Vehicle> lV = new();
                List<NPC.Human> lH = new();
                Road road = new(lV, lH, string.Format("{0}", i)); // Create a new road

                // Assign traffic lights (if enabled) alternately to roads
                if (WithTrafficLight)
                {
                    if (i % 2 == 0)
                    {
                        road.TrafficLight = new(ListTrafficLight.Green);
                    }
                    else
                    {
                        road.TrafficLight = new(ListTrafficLight.Orange);
                    }

                    // Generate a random number of humans for the road
                    int nbrHuman = new Random().Next(0, 3);
                    for (int j = 0; j <= nbrHuman; j++)
                    {
                        // Create human pedestrians and add them to the road
                        road.ListHuman.Add(new NPC.Human(new Random().Next(8, 100), new Random().Next(5, 10), string.Format("Human{0}", j)));
                    }
                }
                ListRoads.Add(road); // Add the created road to the intersection
            }
        }
    }
}
