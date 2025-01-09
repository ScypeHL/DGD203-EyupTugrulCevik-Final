using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public class Adjuster : Game
    {
        public Adjuster()
        {

        }

        public void start()
        {
            notAnswer.Add("Are you here, why are you not answering?");
            notAnswer.Add("Did i scare you?");
            notAnswer.Add("Can you please answer the question first?");
            notAnswer.Add("Okay take your time");
            notAnswer.Add("I have plenty of time so don't worry");

            Abilities.Add("basic attack");
            Abilities.Add("heavy attack");
        }
    }
}
