public class Enemy
{
    string Name;
    protected int Health;
    public List<Attack> AttackList;

    public Enemy(string name)
    {
        Name = name;
        Health = 100;
        AttackList = new List<Attack>(){};
    }

    public Attack RandomAttack()
    {
        Random random = new Random();
        Attack randomAttack = AttackList[random.Next(0,AttackList.Count)];
        // Removed print statement, just return random attack
        return randomAttack;
    }

    public void AddAttack(Attack attack)
    {
        AttackList.Add(attack);
    }

    public string _Name
    {
        get {return Name;}
    }

    public int _Health
    {
        get {return Health;}
        set {Health = value;}
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Enemy Name: {Name}");
        Console.WriteLine($"{Name}'s Health: {Health}");
        Console.WriteLine($"{Name}'s Attacks:");
        foreach (Attack attack in AttackList)
        {
            Console.WriteLine($"- {attack._Name}");
        }
    }

    public void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        // Write some logic here to reduce the Targets health by your Attack's DamageAmount
        Target._Health -= ChosenAttack._DamageAmount;
        Console.WriteLine($"{Name} attacks {Target._Name} with a {ChosenAttack._Name}, dealing {ChosenAttack._DamageAmount} damage and reducing {Target._Name}'s health to {Target._Health}!!");
    }


}