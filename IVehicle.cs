namespace Vehicle
{
    public interface IVehicle{
        public string Brand {get; set;}
        public string HonkSong { get; set; }
        public void Go();
        public void Stop();
        public void Honk();
    }
}