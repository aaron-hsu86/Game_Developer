// create 1 enemy
Enemy enemy1 = new Enemy("Bandit");
// create 3 attacks
Attack attack1 = new Attack("Sword Slash", 10);
Attack attack2 = new Attack("Punch", 5);
Attack attack3 = new Attack("Throw", 7);
// add 3 attacks to enemy
enemy1.AttackList.Add(attack1);
enemy1.AttackList.Add(attack2);
enemy1.AttackList.Add(attack3);
// built into code to write out attack, but it does return the attack class used.
enemy1.RandomAttack();
// not part of assignment, but just wanted to list info.
enemy1.ShowInfo();
Console.WriteLine($"{enemy1._Name} health: {enemy1._Health}");

Attack attack4 = new Attack("Grapple", 3);
enemy1.AddAttack(attack4);
enemy1.ShowInfo();