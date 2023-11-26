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
                bool withTrafficLights = false;
                int nbrRoads = new Random().Next(2, 4);
                int WithTr = new Random().Next(0, 100);
                if (WithTr > 70) {
                    withTrafficLights = true;
                    Console.WriteLine(string.Format("Generating intersection with traffic lights and {0} roads", nbrRoads));
                }
                else
                {
                    Console.WriteLine(string.Format("Generating intersection without traffic lights and {0} roads", nbrRoads));
                }
                Intersection.Intersection intersection = new(nbrRoads, withTrafficLights);
                Console.WriteLine(intersection);
                // Loop through each road
                foreach (Road road in intersection.ListRoads)
                {
                    // Loop through each car in road
                    while (road.ListVehicle.Count > 0)
                    {
                        bool canGo = true;
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        if (withTrafficLights)
                        {
                            if (road.TrafficLight != null)
                            {
                                switch (road.TrafficLight.GetCurrentState())
                                {
                                    case TrafficLight.ListTrafficLight.Red:
                                        Console.WriteLine("The traffic lights is red");
                                        canGo = false;
                                        if (road.ListHuman.Count != 0)
                                        {
                                            road.ListHuman[0].CrossRoad();
                                            road.ListHuman.Remove(road.ListHuman[0]);
                                        }
                                        break;
                                    case TrafficLight.ListTrafficLight.Orange:
                                        Console.WriteLine("The traffic lights is orange");
                                        canGo = false;
                                        break;
                                    case TrafficLight.ListTrafficLight.Green:
                                        Console.WriteLine("The traffic lights is green");
                                        canGo = true;
                                        break;
                                }
                            }
                        }
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