using Intersection;

namespace Vehicle
{
    public interface IVehicle{
        public ListDirection StartingPoint { get; set; }
        public ListDirection DestinationPoint { get; set; }
        public ListBrands Brand {get; set;}
        public int Speed { get; set; }
        public string HonkSong { get; set; }
        public void Go();
        public void Stop();
        public void Honk();
    }
}