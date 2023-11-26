namespace Intersection
{
    public class Road
    {
        public string RoadName { get; set; }
        public List<Vehicle.Vehicle> ListVehicle;
        public TrafficLight.TrafficLight? TrafficLight;
        public List<NPC.Human> ListHuman;
        public Road(List<Vehicle.Vehicle> listVehicle, List<NPC.Human> listHuman,string roadName)
        {
            RoadName = roadName;
            ListVehicle = listVehicle;
            ListHuman = listHuman;
        }

        public override string ToString()
        {
            string result = string.Format("The road {0} contains : \n\n", RoadName);
            if (ListVehicle.Count == 0 && ListHuman.Count == 0)
            {
                result += "Nothing\n";
            } else
            {
                foreach(Vehicle.Vehicle car in ListVehicle)
                {
                    result += car;
                }
            }
            if (ListHuman.Count != 0)
            {
                foreach(NPC.Human human in ListHuman)
                {
                    result += human;
                }
            }
            if (TrafficLight != null)
            {
                result += "\n And a Traffic light";
            }
            return result;
        }
    }
}