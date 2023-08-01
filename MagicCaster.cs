public class MagicCaster : Enemy
{
    public MagicCaster(string name) : base(name)
    {
        Health = 80;
        Attack attack1 = new Attack("Fireball",25);
        Attack attack2 = new Attack("Lightning Bolt",20);
        Attack attack3 = new Attack("Staff Strike",10);
        this.AddAttack(attack1);
        this.AddAttack(attack2);
        this.AddAttack(attack3);
    }

    public void Attack(Enemy Target, string attack)
    {
        Attack atk = this.AttackList.Find(action => action._Name == attack);
        if (atk != null)
        {
            this.PerformAttack(Target, atk);
        }
        else
        {
            Console.WriteLine("Cannot find attack");
        }
    }

    public void Heal(Enemy Target)
    {
        int healAmount = 40;
        Target._Health += healAmount;
        Console.WriteLine($"{Target._Name} is healed for {healAmount}! {Target._Name}'s health is now {Target._Health}.");
    }
}