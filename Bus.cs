namespace Vehicle
{
    public class Bus : Vehicle
    {
        public int nbOfSeat;
        public Bus(string brand, string color, int year, int nbOfSeat)
            : base(brand, color, year)
        {
            this.nbOfSeat = nbOfSeat;
        }
        public override string ToString()
        {
            return "Bus : " + base.ToString() + " " + nbOfSeat + " seats";
        }
    }
}