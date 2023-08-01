//! Game Dev 1 section
// // create 1 enemy
// Enemy enemy1 = new Enemy("Bandit");
// // create 3 attacks
// Attack attack1 = new Attack("Sword Slash", 10);
// Attack attack2 = new Attack("Punch", 5);
// Attack attack3 = new Attack("Throw", 7);
// // add 3 attacks to enemy
// enemy1.AttackList.Add(attack1);
// enemy1.AttackList.Add(attack2);
// enemy1.AttackList.Add(attack3);
// // built into code to write out attack, but it does return the attack class used.
// enemy1.RandomAttack();
// // not part of assignment, but just wanted to list info.
// enemy1.ShowInfo();
// Console.WriteLine($"{enemy1._Name} health: {enemy1._Health}");

// Attack attack4 = new Attack("Grapple", 3);
// enemy1.AddAttack(attack4);
// enemy1.ShowInfo();

//! Game Dev II section
MeleeFighter melee1 = new MeleeFighter("Fighter");
RangedFighter ranged1 = new RangedFighter("Ranger");
MagicCaster caster1 = new MagicCaster("Mage");

melee1.Attack(ranged1, "Kick");
melee1.RageAttack(caster1);
ranged1.Attack(melee1, "Arrow");
ranged1.Dash();
ranged1.Attack(melee1, "Arrow");
caster1.Attack(melee1, "Fireball");
caster1.Heal(ranged1);
caster1.Heal(caster1);
// testing what happens if I put an attack not in the attack list:
// melee1.Attack(caster1, "break");

Console.WriteLine("-=|Character info:|=-");
melee1.ShowInfo();
ranged1.ShowInfo();
caster1.ShowInfo();