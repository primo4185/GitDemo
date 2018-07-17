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
            int hp1 = Marine_UseSteamPack(m1, 2);

            Marine m2 = new Marine();
            int hp2 = Marine_UseSteamPack(m2, 1);

            Heal(m1, 30);

            Marine_GetDamagd(m2, 3);
            Firebat f1 = new Firebat();
            Firebat_UseSteamPack(f1, 1);
            Firebat_UseSteamPackCore(f1);
            Firebat_GetDamagd(f1, 3);
            ShowHp(m1);
            f1.Hp -= 100;
        }

        private static void ShowHp(Marine m1)
        {
           //Console.WriteLine($"m1의 Hp는 {m1.Hp} 이고 Speed는  {m1.Speed} 입니다.");
           //Console.WriteLine($"m1의 Hp는 {0} 이고 Speed는  {1} 입니다.", m1.Hp, m1.Speed);
            Console.WriteLine($"m1의 Hp는 {m1.Hp} 이고 Speed는  {m1.Speed} 입니다.");
        }

        private static void Firebat_GetDamagd(Firebat f1, int enemyAttack)
        {
            f1.Hp -= (enemyAttack * 3);
        }

        private static void Marine_GetDamagd(Marine m, int enemyAttack)
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
        static int Marine_UseSteamPack(Marine m, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Marine_UseSteamPackCore(m);

            }

            return m.Hp;
        }
        static int Firebat_UseSteamPack(Firebat f, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Firebat_UseSteamPackCore(f);

            }

            return f.Hp;
        }
        static void Marine_UseSteamPackCore(Marine m)
        {
            m.Hp = m.Hp - 5;
            m.Speed = m.Speed + 1;
        }
        static void Firebat_UseSteamPackCore(Firebat f)
        {
            f.Hp = f.Hp - 5;
            f.Speed = f.Speed + 1;
        }

        static void Heal(Marine m, int hpToAdd)
        {
            //m.Hp = m.Hp + hpToAdd;
            m.Hp += hpToAdd;
        }

    }
}
