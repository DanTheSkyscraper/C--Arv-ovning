public class Weapon
{
    public string Name;
    public int Damage;
    public virtual int Attack() //Virutal makes it so htat I can override it
    {
        Console.WriteLine($"Attacking with an {Name}");
        return Random.Shared.Next(Damage);
    }
}

