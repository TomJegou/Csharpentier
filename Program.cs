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
                // Initialize variables
                bool withTrafficLights = false;
                int nbrRoads = new Random().Next(2, 4); // Generate a random number of roads between 2 and 3
                int WithTr = new Random().Next(0, 100); // Generate a random number between 0 and 99 for traffic lights probability

                // Determine if traffic lights are present based on probability
                if (WithTr > 70) {
                    withTrafficLights = true;
                    Console.WriteLine(string.Format("Generating intersection with traffic lights and {0} roads", nbrRoads));
                }
                else
                {
                    Console.WriteLine(string.Format("Generating intersection without traffic lights and {0} roads", nbrRoads));
                }
                // BUG : Generating intersection with traffic lights and 2 & 3 roads 
                // Create an intersection object with specified number of roads and traffic lights status
                Intersection.Intersection intersection = new Intersection.Intersection(nbrRoads, withTrafficLights);
                Console.WriteLine(intersection);

                // Loop through each road in the intersection
                foreach (Road road in intersection.ListRoads)
                {
                    // Loop through each vehicle on the road
                    while (road.ListVehicle.Count > 0)
                    {
                        bool canGo = true;
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();

                        // Check if traffic lights are present
                        if (withTrafficLights)
                        {
                            if (road.TrafficLight != null)
                            {
                                switch (road.TrafficLight.GetCurrentState())
                                {
                                    case TrafficLight.ListTrafficLight.Red:
                                        Console.WriteLine("The traffic light is red");
                                        canGo = false;
                                        // Remove a human crossing the road (if any) when the light is red
                                        if (road.ListHuman.Count != 0)
                                        {
                                            road.ListHuman[0].CrossRoad();
                                            road.ListHuman.Remove(road.ListHuman[0]);
                                        }
                                        break;
                                    case TrafficLight.ListTrafficLight.Orange:
                                        Console.WriteLine("The traffic light is orange");
                                        canGo = false;
                                        break;
                                    case TrafficLight.ListTrafficLight.Green:
                                        Console.WriteLine("The traffic light is green");
                                        canGo = true;
                                        break;
                                }
                            }
                        }

                        // Allow vehicles to proceed if the condition permits
                        if (canGo)
                        {
                            road.ListVehicle[0].Go();
                            road.ListVehicle.Remove(road.ListVehicle[0]);
                        }
                    }
                }
            }
        }
    }
}
