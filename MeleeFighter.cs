public class MeleeFighter : Enemy
{
    public MeleeFighter(string name) : base(name)
    {
        Health = 120;
        Attack attack1 = new Attack("Punch",20);
        Attack attack2 = new Attack("Kick",15);
        Attack attack3 = new Attack("Tackle",25);
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

    public void RageAttack(Enemy Target)
    {
        Attack rageAttack = this.RandomAttack();
        rageAttack._DamageAmount += 10;
        rageAttack._Name = "Rage " + rageAttack._Name;
        this.PerformAttack(Target, rageAttack);
    }
}