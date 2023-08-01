public class MeleeFighter : Enemy
{
    public MeleeFighter(string name) : base(name)
    {
        Health = 120;
        MaxHealth = 120;
        Attack attack1 = new Attack("Punch",20);
        Attack attack2 = new Attack("Kick",15);
        Attack attack3 = new Attack("Tackle",25);
        this.AddAttack(attack1);
        this.AddAttack(attack2);
        this.AddAttack(attack3);
    }
//! Not using this for now because I've set up a string parameter to search for the attack
// use the performAttack in parent
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
                if (attack == "Punch")
                {
                    Console.Write("Spinning wildly, the ");
                }
                else if (attack == "Kick")
                {
                    Console.Write("With a flip, the ");
                }
                else if (attack == "Tackle")
                {
                    Console.Write("Screaming a primal warcry, the ");
                }
                this.PerformAttack(Target, atk);
            }
            else
            {
                Console.WriteLine("Cannot find attack");
            }
        }
    }

    public void RageAttack(Enemy Target)
    {
        if (Target.Health <= 0 )
        {
            Console.WriteLine($"{Target.Name} is already down, cannot attack!");
        }
        else
        {
            Attack rageAttack = this.RandomAttack();
            rageAttack.Damage += 10;
            Console.Write("Full of rage, ");
            this.PerformAttack(Target, rageAttack);
        }
    }
}