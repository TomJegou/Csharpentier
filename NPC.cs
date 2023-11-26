namespace NPC
{
    public class NPC : INPC
    { 
        public int Age {get; set;}
        public int Vitesse {get; set;}
        public NPC(int age, int vitesse)
        {
            Age = age;
            Vitesse = vitesse;
        }
    }
}