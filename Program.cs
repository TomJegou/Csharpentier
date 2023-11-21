using Intersection;

namespace Program
{
    class Program()
    {
        public static void Main()
        {
            Intersection.Intersection myIntersection = new(4, 4);
            myIntersection.Generate();
            myIntersection.ListRoads.ForEach(delegate(Road road){Console.WriteLine(road);});
        }
    }
}