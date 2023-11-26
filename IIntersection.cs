namespace Intersection
{
    public interface IIntersection
    {
        public int NbrRoads { get; set; }
        public int NbrCrossWalkers { get; set; }
        public void Generate();
        public List<Road> ListRoads { get; set; }
    }
}