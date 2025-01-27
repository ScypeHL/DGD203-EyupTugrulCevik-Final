using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public struct Ability
    {
        public Ability()
        {
            description = "";
            ccDealy = 0;
        }
        
        public string name;
        public string description;
        public float apScale;
        public float spScale;
        public float cooldown;
        public int ccDealy;
    }
}
