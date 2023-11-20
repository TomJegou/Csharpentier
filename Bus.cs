namespace Vehicle
{
    public class Bus : Vehicle
    {

        private int speed = 0; // m/s
        public Bus(string brand, string honkSong,int speed): base(brand, honkSong)
        {
            this.speed = speed;
        }

    public int GetSpeed {
        get { return this.speed; }
    }

    }
}