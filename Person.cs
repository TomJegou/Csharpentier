public class NPC 
{
    public NPC(int age, int vitesse )
    {
        this.Age = age;
        this.Vitesse = vitesse;
    }

    public enum StadeDeVie
{
    Enfant,
    Adulte,
    Vieux  
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



