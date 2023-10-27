public class Fighter
{
    public string name;
    public int agility = 10;
    public int strength = 10;

    public Axe axe;
    public Sword sword;

    public Weapon weapon;

    public int Attack()
    {
        return weapon.Attack();
    }
}
