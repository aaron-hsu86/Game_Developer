public class MagicCaster : Enemy
{
    public MagicCaster(string name) : base(name)
    {
        Health = 80;
        MaxHealth = Health;
        Attack attack1 = new Attack("Fireball",25);
        Attack attack2 = new Attack("Lightning Bolt",20);
        Attack attack3 = new Attack("Staff Strike",10);
        this.AddAttack(attack1);
        this.AddAttack(attack2);
        this.AddAttack(attack3);
    }

    //! Not using this for now because I've set up a string parameter to search for the attack
    // public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    // {
    //     base.PerformAttack(Target, ChosenAttack);
    // }

    public void UseAttack(Enemy Target, string attack)
    {
        if (Target.Health <= 0 )
        {
            Console.WriteLine($"{Target.Name} is already down, cannot attack!");
        }
        else
        {
            Attack atk = this.AttackList.Find(action => action.Name == attack);
            if (atk != null)
            {
                this.PerformAttack(Target, atk);
            }
            else
            {
                Console.WriteLine("Cannot find attack");
            }
        }
    }

    public void Heal(Enemy Target)
    {
        int healAmount = 40;
        if (Target.Health + healAmount > Target.MaxHealth)
        {
            Target.Health = Target.MaxHealth;
        }
        else
        {
            Target.Health += healAmount;
        }
        Console.WriteLine($"{Target.Name} is healed for {healAmount}! {Target.Name}'s health is now {Target.Health}.");
    }
}