namespace Person
{
    public interface IPerson{
        public int Age { get; set; }
        public int Vitesse { get; set; }
        public StadeDeVie ClasserParAge();
    }
}