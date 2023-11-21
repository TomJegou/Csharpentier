using Intersection;

namespace Program
{
    class Program()
    {
        public static void Main()
        {
            Intersection.Intersection myIntersection = new(3, 0);
            myIntersection.Generate();
            Console.WriteLine(myIntersection);
            while (true)
            {
                Console.ReadKey();
            }
        }
    }
}