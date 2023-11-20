using System.Collections.Specialized;
using System.IO;
using Microsoft.VisualBasic;

namespace Intersection
{
    public class Intersection(int nbrRoads, int nbrCrossWalk): IIntersection
    {
        public int NbrRoads { get; set; } = nbrRoads;
        public int NbrCrossWalk { get; set; } = nbrCrossWalk;

        public override string? ToString()
        {
            using FileStream fs = File.OpenRead("assets/Intersection.txt");
            byte[] buf = new byte[1048];
            fs.Read(buf);
            return Convert.ToString(buf);
        }
    } 
}