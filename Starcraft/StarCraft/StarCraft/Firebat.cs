using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCraft
{
    class Firebat : Unit
    {
        public override void GetDamaged(int enemyAttack)
        {
            Hp -= (enemyAttack * 3);
        }
    }
}
