public class Enemy
{
    string Name;
    int Health;
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
        Console.WriteLine($"{Name} attacked with {randomAttack._Name}, dealing {randomAttack._Damage} damage!");
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
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Enemy name: {Name}");
        Console.WriteLine($"{Name}'s health: {Health}");
        Console.WriteLine($"{Name}'s Attacks:");
        foreach (Attack attack in AttackList)
        {
            Console.WriteLine($"- {attack._Name}");
        }
    }
}