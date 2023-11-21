using listStadeDeVie;

namespace Person{
    public class NPC(int age, int vitesse)
    { 
        public int Age {get; set;} = age;
        public int Vitesse {get; set;} = vitesse;
        //Méthode pour détecter quel est le stade de vie du NPC
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