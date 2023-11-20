namespace Intersection
{
    public class Intersection(int nbrRoads, int nbrCrossWalk): IIntersection
    {
        public int NbrRoads { get; set; } = nbrRoads;
        public int NbrCrossWalk { get; set; } = nbrCrossWalk;

        public override string ToString()
        {
            return "";
        }
    } 
}