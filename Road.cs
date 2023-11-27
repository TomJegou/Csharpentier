namespace Intersection
{
    public class Road
    {
        // Name of the road
        public string RoadName { get; set; }

        // List of vehicles on the road
        public List<Vehicle.Vehicle> ListVehicle;

        // Traffic light on the road (nullable)
        public TrafficLight.TrafficLight? TrafficLight;

        // List of pedestrians (humans) on the road
        public List<NPC.Human> ListHuman;

        // Constructor for the Road class
        public Road(List<Vehicle.Vehicle> listVehicle, List<NPC.Human> listHuman, string roadName)
        {
            RoadName = roadName;
            ListVehicle = listVehicle;
            ListHuman = listHuman;
        }

        // Override of ToString method to display road details
        public override string ToString()
        {
            string result = string.Format("The road {0} contains : \n\n", RoadName);

            // Check if the road has no vehicles or pedestrians
            if (ListVehicle.Count == 0 && ListHuman.Count == 0)
            {
                result += "Nothing\n";
            }
            else
            {
                // Display details of vehicles on the road
                foreach (Vehicle.Vehicle car in ListVehicle)
                {
                    result += car; // Assuming Vehicle class has an overridden ToString method
                }
            }

            // Display details of pedestrians on the road if there are any
            if (ListHuman.Count != 0)
            {
                foreach (NPC.Human human in ListHuman)
                {
                    result += human; // Assuming Human class has an overridden ToString method
                }
            }

            // Check if there's a traffic light on the road and include it in the result
            if (TrafficLight != null)
            {
                result += "\n And a Traffic light";
            }

            return result;
        }
    }
}
