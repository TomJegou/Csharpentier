namespace NPC
{
    public class Humain : NPC
    {
        bool AsCrossed { get; set; }
        public string Name { get; set; }
        public Humain(int age, int speed, string name) : base(age, speed)
        {
            Age = age;
            Speed = speed;
            Name = name;
        }

        public override string ToString()
        {
            return string.Format("Humain:\n*   {0}\n*   {1}\n*   {2}", Age, Speed, Name);
        }
    }
}