public class Attack
{
    string Name;
    int Damage;

    public Attack(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }

    public string _Name
    {
        get {return Name;}
    }
    public int _Damage
    {
        get {return Damage;}
    }
}