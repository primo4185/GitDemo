using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCraft
{
    class Program
    {
        static void Main(string[] args)
        {
            Marine m1 = new Marine();
            int hp1 = UseSteamPack(m1, 2);

            Marine m2 = new Marine();
            int hp2 = UseSteamPack(m2, 1);

            Heal(m1, 30);

            GetDamagd(m2, 3);
        }

        private static void GetDamagd(Marine m, int enemyAttack)
        {
            m.Hp -= (enemyAttack * 2);
        }

        /* static int UseSteamPack(Marine m, int count)
{
    for (int i = 0; i < count; i++)
    {
        m.Hp = m.Hp - 5;
        m.Speed = m.Speed + 1;

    }

    return m.Hp; */
        static int UseSteamPack(Marine m, int count)
        {
            for (int i = 0; i < count; i++)
            {
                UseSteamPackCore(m);

            }

            return m.Hp;
        }
        static void UseSteamPackCore(Marine m)
        {
            m.Hp = m.Hp - 5;
            m.Speed = m.Speed + 1;
        }
        static void Heal(Marine m, int hpToAdd)
        {
            //m.Hp = m.Hp + hpToAdd;
            m.Hp += hpToAdd;
        }

    }
}
