public class RangedFighter : Enemy
{
    int Distance;
    public RangedFighter(string name) : base(name)
    {
        Distance = 5;
        MaxHealth = Health;
        Attack attack1 = new Attack("Arrow",20);
        Attack attack2 = new Attack("Knife",15);
        this.AddAttack(attack1);
        this.AddAttack(attack2);
    }
//! Not using this for now because I've set up a string parameter to search for the attack
// use the performAttack in parent
    public void UseAttack(Enemy Target, string attack)
    {
        if (Target.Health <= 0 )
        {
            Console.WriteLine($"{Target.Name} is already down, cannot attack!");
        }
        else if (Distance < 10)
        {
            Console.WriteLine($"Enemy too close, {this.Name} cannot attack!");
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

    public void Dash()
    {
        this.Distance = 20;
        Console.WriteLine($"{this.Name} used the Dash action!");
    }


}