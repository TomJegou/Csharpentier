using TrafficLight;

namespace Intersection
{
    public class Road
    {
        public string RoadName { get; set; }
        public List<Vehicle.Vehicle> ListVehicle;

        public TrafficLight.TrafficLight? TrafficLight;

        public Road(List<Vehicle.Vehicle> listVehicle, string roadName, TrafficLight.TrafficLight? trafficLight = null)
        {
            RoadName = roadName;
            ListVehicle = listVehicle;
            TrafficLight = trafficLight;
        }

        public override string ToString()
        {
            string result = string.Format("The road {0} contains : \n\n", RoadName);
            if (ListVehicle.Count == 0)
            {
                result += "Nothing\n";
            } else
            {
                foreach (Vehicle.Vehicle car in ListVehicle)
                {
                    result += car;
                }
            }
            return result;
        }
    }
}