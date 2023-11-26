namespace NPC
{
    public class NPC : INPC
    { 
        public int Age {get; set;}
        public int Speed {get; set;}
        public NPC(int age, int speed)
        {
            Age = age;
            Speed = speed;
        }
    }
}