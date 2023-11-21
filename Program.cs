using Intersection;

namespace Program
{
    class Program()
    {
        public static void Main()
        {
            Intersection.Intersection myIntersection = new(4, 4);
            myIntersection.Generate();
            Console.WriteLine(myIntersection);
        }
    }
}