namespace Intersection
{
    public class Road(List<Vehicle.Vehicle> listVehicle, string roadName)
    {
        public string RoadName { get; set; } = roadName;
        public List<Vehicle.Vehicle> ListVehicle = listVehicle;

        public override string ToString()
        {
            string result = string.Format("The road {0} contains : \n", RoadName);
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