namespace Intersection
{
    public class Intersection(): IIntersection
    {
        public int NbrRoads { get; set; }
        public int NbrCrossWalk { get; set; }
        public List<Road> ListRoads { get; set; } = [];
        
        public Intersection(int nbrRoads, int nbrCrossWalk)
        {
            NbrRoads = nbrRoads;
            NbrCrossWalk = nbrCrossWalk;
            Generate();

        }

        public override string? ToString()
        {
            return File.ReadAllText("assets/Intersection.txt");
        }

        public void Generate()
        {
            for (int i  = 0; i <= NbrRoads; i++)
            {
                List<Vehicle.Vehicle> lV = [];
                Road road = new(lV, string.Format("{0}", i));
                ListRoads.Add(road);
            }
        }
    }
}