using Intersection;

namespace Vehicle
{
    public interface IVehicle{
        public Road StartingPoint { get; set; }
        public Road DestinationPoint { get; set; }
        public Road CurrentPoint { get; set; }
        public ListBrands Brand {get; set;}
        public int Speed { get; set; }
        public string HonkSong { get; set; }
        public void Go();
        public void Stop();
        public void Honk();
        public static int[] GetSpeedList()
        {
            int[] result = {100, 150, 160, 180, 200, 300};
            return result;
        }
    }
}