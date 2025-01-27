using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public class Effects:Game
    {
        public Effects()
        {

        }

        public void healing(float regen)
        {
            if (currentHp + regen > Hp)
            {
                float hpDiff;
                
                hpDiff = Hp - currentHp;
                currentHp = Hp;
                Console.WriteLine($"Your hp is healed by {hpDiff}");
                Console.WriteLine($"Your hp is now {currentHp}");
            }
            else
            {
                currentHp = currentHp + regen;
                Console.WriteLine($"Your hp is healed by {regen}");
                Console.WriteLine($"Your hp is now {currentHp}");
            }
            
        }
    }
}
