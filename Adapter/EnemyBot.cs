using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class EnemyBot : IEnemyBot
    {
        Random random = new Random();

        public void FestAttack()
        {
            var damge = random.Next(10);
            Console.WriteLine($@"Bot causes {damge} damge");
        }

        public void WalkForword()
        {
            var movement = random.Next(5);
            Console.WriteLine($@"Bot walked {movement} steps");
        }
    }
}
