namespace Intersection
{
    public class Road(List<Vehicle.Vehicle> listVehicle, string roadName)
    {
        public string RoadName { get; set; } = roadName;
        public List<Vehicle.Vehicle> ListVehicle = listVehicle;

        public override string ToString()
        {
            string result = string.Format("The road {0} contains : \n", RoadName);
            foreach (Vehicle.Vehicle car in ListVehicle)
            {
                result += car;
            }
            return result;
        }
    }
}