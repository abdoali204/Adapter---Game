using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class EnemyTank : IEnemyAttacker
    {
        Random random = new Random();
        public void FireWeapon()
        {
            var damge = random.Next(10);
            Console.WriteLine($@"Enemy Tank does {random.Next(10)} damge");
        }
        public void DriveForword()
        {
            var movement = random.Next(5);
            Console.WriteLine($@"Enemy tank moves {movement} meters");
        }
    }
}
