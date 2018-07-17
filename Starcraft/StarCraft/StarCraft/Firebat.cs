using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCraft
{
    class Firebat
    {
        public int Hp;
        public int Speed;
        public int UseSteamPack(int count)
        {
            for (int i = 0; i < count; i++)
            {
                UseSteamPackCore();

            }

            return Hp;
        }

        public void UseSteamPackCore()
        {
            Hp = Hp - 5;
            Speed = Speed + 1;
        }

        public void GetDamagd(int enemyAttack)
        {
            Hp -= (enemyAttack * 3);
        }
    }
}
