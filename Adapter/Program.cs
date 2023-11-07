// See https://aka.ms/new-console-template for more information
using Adapter;


#region Let's imagine that the current implementation
IEnemyAttacker enemyAttacker = new EnemyTank();

enemyAttacker.FireWeapon();
enemyAttacker.DriveForword();
#endregion

#region replacement without adapter 
IEnemyBot enemyBot = new EnemyBot();

enemyBot.FestAttack();
enemyBot.WalkForword();
#endregion


#region replacement with adapter -- with DI injection we will have no change at all in the client implementation
IEnemyAttacker botAttacker = new EnemyAdapterBot(new EnemyBot());
botAttacker.FireWeapon();
botAttacker.DriveForword();

#endregion

Console.ReadLine();