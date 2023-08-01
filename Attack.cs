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
        set {Name = value;}
    }
    public int _DamageAmount
    {
        get {return Damage;}
        set {Damage = value;}
    }
}