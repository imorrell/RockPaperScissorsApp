using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsApp
{
    class PlayerTwo : Player
    {
        //return random number between random choice from enum Roshambo
        public override Roshambo GetRoshambo()
        {
            Random rnd = new Random();
         

            //generate random number from 1 to 3
            int random = rnd.Next(1, 4);

            //return Rock
            if (random == 1)
            {
                return Roshambo.Rock;
            }
            //return paper
            else if (random == 2)
            {
                return Roshambo.Paper;
            }
            //return scissors
            else
            {
                return Roshambo.Scissors;
            }
           
        }
    }
}
