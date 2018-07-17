using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCraft
{
    class Marine
    {
        public int Hp;
        public int Speed;
        public void GetDamagd(int enemyAttack)
        {
            Hp -= (enemyAttack * 2);
        }
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
        public void Heal(int hpToAdd)
        {
            Hp += hpToAdd;
        }
    }
}
