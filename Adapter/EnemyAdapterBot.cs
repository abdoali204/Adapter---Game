namespace Adapter
{
    public class EnemyAdapterBot : IEnemyAttacker
    {
        private IEnemyBot bot;
        public EnemyAdapterBot(IEnemyBot bot)
        {
            this.bot = bot;
        }

        public void DriveForword()
        {
            bot.WalkForword();
        }

        public void FireWeapon()
        {
            bot.FestAttack();
        }
    }
}
