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
            Unit m3 = new Marine();
            Unit f3 = new Firebat();

            Unit[] units = new Unit[2];
            units[0] = m3;
            units[1] = f3;

            for (int i = 0; i < units.Length; i++)
            {
                units[i].GetDamaged(2);
            }
            for (int i = 0; i < units.Length; i++)
            {
                ShowHP(units[i]);
            }

        }
        static void ShowHP(Unit u)
        {
            Console.WriteLine($"Hp는 {u.GetHp()} 입니다.");
        }

    }
}
