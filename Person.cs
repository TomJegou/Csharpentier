namespace Person
{
    public class NPC
    { 
        public int Age {get; set;}
        public int Vitesse {get; set;}
        //Méthode pour détecter quel est le stade de vie du NPC
        public NPC(int age, int vitesse)
        {
            Age = age;
            Vitesse = vitesse;
        }
        public StadeDeVie ClasserParAge()
        {
            if (Age < 18)
            {
                return StadeDeVie.Enfant;
            }
            else if (Age >= 18 && Age < 60)
            {
                return StadeDeVie.Adulte;
            }
            else
            {
                return StadeDeVie.Vieux;
            }
        }
    }
}