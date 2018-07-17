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
            int hp1 = m1.UseSteamPack(2);

            Marine m2 = new Marine();
            int hp2 = m2.UseSteamPack(1);

            m1.Heal(30);

            m2.GetDamagd(3);
            Firebat f1 = new Firebat();
            f1.UseSteamPack(1);
            //f1.UseSteamPackCore(1);
            f1.GetDamagd(3);


        }




 

        /* static int UseSteamPack(Marine m, int count)
{
    for (int i = 0; i < count; i++)
    {
        m.Hp = m.Hp - 5;
        m.Speed = m.Speed + 1;

    }

    return m.Hp; */

        }

        }

    }
}
