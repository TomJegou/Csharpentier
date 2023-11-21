using Vehicle;

namespace Intersection
{
    public class Intersection(int nbrRoads, int nbrCrossWalk): IIntersection
    {
        public int NbrRoads { get; set; } = nbrRoads;
        public int NbrCrossWalk { get; set; } = nbrCrossWalk;
        public List<Road> ListRoads { get; set; } = [];

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
                    ListRoads[i].ListVehicle.Add(new Vehicle.Vehicle(ListBrands.BMW, 300, "TUUT TUUT !", ListRoads[sP], ListRoads[dP], ListVehicle.Car));
                }
            }
        }

        public void GenerateRoad()
        {
            for (int i  = 0; i < NbrRoads; i++)
            {
                List<Vehicle.Vehicle> lV = [];
                Road road = new(lV, string.Format("{0}", i));
                ListRoads.Add(road);
            }
        }
    }
}