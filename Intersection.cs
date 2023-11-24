using Vehicle;

namespace Intersection
{
    public class Intersection: IIntersection
    {
        public int NbrRoads { get; set; }
        public int NbrCrossWalk { get; set; }
        public List<Road> ListRoads { get; set; } = new();
        public Boolean WithTrafficLight { get; set; }
        public Intersection(int nbrRoads, int nbrCrossWalk,Boolean withTrafficLight)
        {
            NbrRoads = nbrRoads;
            NbrCrossWalk= nbrCrossWalk;
            Generate();
        }

        public override string? ToString()
        {
            string result = File.ReadAllText("assets/Intersection.txt");
            ListRoads.ForEach(delegate(Road road)
            {
                result += road;
            });
            return result;
        }

        public void Generate()
        {
            GenerateRoad();
            GenerateVehiles();
        }

        public void GenerateVehiles()
        {
            for (int i  = 0; i < NbrRoads; i++)
            {
                int nbrV = new Random().Next(0, 3);
                for (int j = 0; j < nbrV; j++)
                {
                    int sP = new Random().Next(0, ListRoads.Count);
                    int dP = new Random().Next(0, ListRoads.Count);
                    ListBrands[] brands = (ListBrands[])Enum.GetValues(typeof(ListBrands));
                    ListBrands brand = brands[new Random().Next(brands.Length)];
                    ListVehicle[] vehicles = (ListVehicle[])Enum.GetValues(typeof(ListVehicle));
                    ListVehicle vehicle = vehicles[new Random().Next(vehicles.Length)];
                    int[] listSpeed = IVehicle.GetSpeedList();
                    ListRoads[i].ListVehicle.Add(new Vehicle.Vehicle(brand, listSpeed[new Random().Next(listSpeed.Length)], "TUUT TUUT !", ListRoads[sP], ListRoads[dP], vehicle));
                }
            }
        }

        public void GenerateRoad()
        {
            for (int i  = 0; i < NbrRoads; i++)
            {
                List<Vehicle.Vehicle> lV = new();
                Road road = new(lV, string.Format("{0}", i));
                ListRoads.Add(road);
            }
        }
    }
}