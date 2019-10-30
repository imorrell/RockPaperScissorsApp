using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsApp
{
    class PlayerOne : Player
    {
        //This player only returns Rock
        public override Roshambo GetRoshambo()
        {
            return Roshambo.Rock;
        }
    }
}
