using Intersection;

namespace Vehicle
{
    public class Bus : Vehicle
    {
        public Bus(ListDirection startingPoint, ListDirection destinationPoint, ListBrands brand, int speed, string honkSong) : base(startingPoint, destinationPoint, brand, honkSong,speed)
        {
        }
    }
}
