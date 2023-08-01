public class RangedFighter : Enemy
{
    int Distance;
    public RangedFighter(string name) : base(name)
    {
        Distance = 5;
        Attack attack1 = new Attack("Arrow",20);
        Attack attack2 = new Attack("Knife",15);
        this.AddAttack(attack1);
        this.AddAttack(attack2);
    }

    public void Attack(Enemy Target, string attack)
    {
        if (Distance < 10)
        {
            Console.WriteLine($"Enemy too close, {this._Name} cannot attack!");
        }
        else
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
    }

    public void Dash()
    {
        this.Distance = 20;
        Console.WriteLine($"{this._Name} used the Dash action!");
    }


}