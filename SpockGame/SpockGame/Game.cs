using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SpockGame
{
    //Yes, this is a reference to big bang theory
    public class Game
    {
        public PlayResult DoPlay(Play first, Play second)
        {
            if (first == second)
                return PlayResult.Tie;

            int nfirst = (int)first;
            int nsecond = (int)second;

            if (nsecond == (nfirst + 1) % 5 || nsecond == (nfirst + 2) % 5)
                return PlayResult.SecondPlayer;

            return PlayResult.FirstPlayer;
        }
    }
}
