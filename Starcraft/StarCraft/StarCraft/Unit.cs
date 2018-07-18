using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCraft
{
    abstract class Unit
    {
        protected int Hp = 60;
        protected int Speed = 1;
        public int GetHp()
        {
            return Hp;
        }
        public virtual void GetDamaged(int enemyAttack)
        {
            Hp -= enemyAttack;
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
