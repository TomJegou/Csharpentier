namespace NPC
{
    public class Humain : NPC
    {
        public bool AsCrossed { get; set; } = false;
        public string Name { get; set; }
        public Humain(int age, int speed, string name) : base(age, speed)
        {
            Age = age;
            Speed = speed;
            Name = name;
        }

        public override string ToString()
        {
            return string.Format("Humain:\n*   {0}\n*   {1}\n*   {2}\n", Age, Speed, Name);
        }

        public void CrossRoad()
        {
            Console.WriteLine(string.Format("Human : My name is {0} and I'm crossing the road !", Name));
            AsCrossed = true;
        }
    }
}