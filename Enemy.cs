public class Enemy
{
    public string Name {get;}
    public int Health {get; set;}
    public List<Attack> AttackList;
    public int MaxHealth {get; set;}

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
        return randomAttack;
    }

    public void AddAttack(Attack attack)
    {
        AttackList.Add(attack);
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Enemy Name: {Name}");
        Console.WriteLine($"{Name}'s Health: {Health}");
        Console.WriteLine($"{Name}'s Attacks:");
        foreach (Attack attack in AttackList)
        {
            Console.WriteLine($"- {attack.Name}");
        }
    }

    public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        // Write some logic here to reduce the Targets health by your Attack's DamageAmount
        Target.Health -= ChosenAttack.Damage;
        Console.WriteLine($"{Name} attacks {Target.Name} with a {ChosenAttack.Name}, dealing {ChosenAttack.Damage} damage and reducing {Target.Name}'s health to {Target.Health}!!");
    }


}