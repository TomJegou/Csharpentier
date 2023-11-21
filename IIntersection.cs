namespace Intersection
{
    public interface IIntersection
    {
        public int NbrRoads { get; set; }
        public int NbrCrossWalk { get; set; }
        public void Generate();
        public List<Road> ListRoads { get; set; }
    }
}