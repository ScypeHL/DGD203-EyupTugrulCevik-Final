using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class AbilityList
    {
        public Dictionary<int, Ability> _abilities;
        public AbilityList()
        {

        }

        public void register(string className)
        {
            basicAttack();
            heavyAttack();

            switch (className)
            {
                case "Hunter":
                    kingSlicer();
                    holeMaker();
                    break;
                case "Archer":
                    piercingShot();
                    arrowRain();
                    break;
                case "Sorcerer":
                    frozenStrike();
                    fireball();
                    break;
                case "Warrior":
                    silverSteel();
                    edgeOfTheHell();
                    break;
            }
        }

        void basicAttack()
        {
            Ability basic = new Ability();
            basic.name = "Basic Attack";
            basic.apScale = 1;
            basic.spScale = 0;
            basic.cooldown = 1;
            _abilities[1] = basic;
        }

        void heavyAttack()
        {
            Ability heavy = new Ability();
            heavy.name = "Heavy Attack";
            heavy.apScale = 1.6f;
            heavy.spScale = 2.5f;
            heavy.cooldown = 3f;
            _abilities[2] = heavy;
        }

        void frozenStrike()
        {
            Ability frozen = new Ability();
            frozen.name = "Frozen Strike";
            frozen.apScale = 0.1f;
            frozen.spScale = 2f;
            frozen.cooldown = 2.2f;
            frozen.ccDealy = 300;
            _abilities[3] = frozen;
        }

        void fireball()
        {
            Ability fire = new Ability();
            fire.name = "Fireball";
            fire.apScale = 0.4f;
            fire.spScale = 1.8f;
            fire.cooldown = 1.8f;
            _abilities[4] = fire;
        }

        void piercingShot()
        {
            Ability piercing = new Ability();
            piercing.name = "Piercing Shot";
            piercing.apScale = 1.7f;
            piercing.spScale = 0;
            piercing.cooldown = 2f;
            _abilities[3] = piercing;
        }

        void arrowRain()
        {
            Ability rain = new Ability();
            rain.name = "Arrow Rain";
            rain.apScale = 1.2f;
            rain.spScale = 0.4f;
            rain.cooldown = 1.6f;
            _abilities[4] = rain;
        }

        void silverSteel()
        {
            Ability silver = new Ability();
            silver.name = "Silver Steel";
            silver.apScale = 1.2f;
            silver.spScale = 0.1f;
            silver.cooldown = 1.2f;
            _abilities[3] = silver;
        }

        void edgeOfTheHell()
        {
            Ability edge = new Ability();
            edge.name = "Edge Of The Hell";
            edge.apScale = 3;
            edge.spScale = 0.9f;
            edge.cooldown = 3.5f;
            _abilities[4] = edge;
        }

        void holeMaker()
        {
            Ability hole = new Ability();
            hole.name = "Hole Maker";
            hole.apScale = 1.2f;
            hole.spScale = 1.5f;
            hole.cooldown = 1.3f;
            _abilities[3] = hole;
        }

        void kingSlicer()
        {
            Ability king = new Ability();
            king.name = "King Slicer";
            king.apScale = 1.7f;
            king.spScale = 1.7f;
            king.cooldown = 2.1f;
            _abilities[4] = king;
        }
    }
}
