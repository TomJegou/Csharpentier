using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
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
            return File.ReadAllText("assets/Intersection.txt");
        }

        public void Generate()
        {
            for (int i  = 0; i < NbrRoads; i++)
            {
                List<Vehicle.Vehicle> lV = [];
                int nbrV = new Random().Next(0, 3);
                for (int j = 0; j < nbrV; j++)
                {
                    int sP = new Random().Next(0, ListRoads.Count);
                    int dP = new Random().Next(0, ListRoads.Count);
                    lV.Add(new Vehicle.Vehicle(ListBrands.BMW, 300, "TUUT TUUT !", ListRoads[sP], ListRoads[dP], ListVehicle.Car));
                }
                Road road = new(lV, string.Format("{0}", i));
                ListRoads.Add(road);
            }
        }
    }
}