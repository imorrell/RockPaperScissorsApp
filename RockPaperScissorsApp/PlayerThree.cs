using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsApp
{
    class PlayerThree : Player
    {
        public override Roshambo GetRoshambo()
        {
            //initalize variables
            string userChoice;

            //prompt user to enter their choice for Rock, Paper, Scissors
            userChoice = Validator.GetUserInputTwo("Rock, Paper or Scissors?(R/P/S)\n");

            //use if else loop to process user input
            if (userChoice.Equals("r", StringComparison.OrdinalIgnoreCase))
            {
                //return rock
                return Roshambo.Rock;
            }
            else if (userChoice.Equals("p", StringComparison.OrdinalIgnoreCase))
            {
                //return paper
                return Roshambo.Paper;
            }
            else if (userChoice.Equals("s", StringComparison.OrdinalIgnoreCase))
            {
                //return scissors
                return Roshambo.Scissors;
            }
            else
            {
                //user enter wrong input. Use recursion to recall the method
                Console.WriteLine("Wrong input! Please enter correct input.\n");
                return GetRoshambo();
            }
        }
    }
}
