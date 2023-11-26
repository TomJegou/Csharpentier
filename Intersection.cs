using Vehicle;
using TrafficLight;

namespace Intersection
{
    public class Intersection: IIntersection
    {
        public int NbrRoads { get; set; }
        public int NbrCrossWalkers { get; set; }
        public List<Road> ListRoads { get; set; } = new();
        public bool WithTrafficLight { get; set; }
        public Intersection(int nbrRoads, bool withTrafficLight)
        {
            NbrRoads = nbrRoads;
            WithTrafficLight = withTrafficLight;
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
            GenerateVehicles();
        }

        public void GenerateVehicles()
        {
            Random random = new();
            
            for (int i = 0; i < NbrRoads; i++)
            {
                int nbrVehicles = random.Next(0, 3);

                for (int j = 0; j < nbrVehicles; j++)
                {
                    int startPointIndex = random.Next(0, ListRoads.Count);
                    int destinationPointIndex = random.Next(0, ListRoads.Count);
                    
                    if (startPointIndex < ListRoads.Count && destinationPointIndex < ListRoads.Count)
                    {
                        ListBrands[] brands = (ListBrands[])Enum.GetValues(typeof(ListBrands));
                        ListBrands brand = brands[random.Next(brands.Length)];
                        
                        ListVehicle[] vehicles = (ListVehicle[])Enum.GetValues(typeof(ListVehicle));
                        ListVehicle vehicle = vehicles[random.Next(vehicles.Length)];
                        
                        int[] speedList = IVehicle.GetSpeedList();
                        int speedIndex = random.Next(speedList.Length);
                        int speed = speedList[speedIndex];
                        
                        ListRoads[i].ListVehicle.Add(new Vehicle.Vehicle(brand, speed, "TUUT TUUT !", ListRoads[startPointIndex], ListRoads[destinationPointIndex], vehicle));
                    }
                }
            }
        }

        public void GenerateRoad()
        {
            for (int i  = 0; i < NbrRoads; i++)
            {
                List<Vehicle.Vehicle> lV = new();
                List<NPC.Human> lH = new();
                Road road = new(lV, lH,string.Format("{0}", i));
                if (WithTrafficLight)
                {
                    if (i%2 == 0)
                    {
                        road.TrafficLight = new(ListTrafficLight.Green);
                    }
                    else
                    {
                        road.TrafficLight = new(ListTrafficLight.Orange);
                    }
                    int nbrHuman = new Random().Next(0, 3);
                    for (int j = 0; i <= nbrHuman; i++) {
                        road.ListHuman.Add(new NPC.Human(new Random().Next(8, 100), new Random().Next(5, 10), string.Format("Human{0}", j)));
                    }
                }
                ListRoads.Add(road);
            }
        }
    }
}