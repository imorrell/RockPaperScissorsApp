using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsApp
{
    class RoshamboApp
    {
       //the PlayGame method allows the user to play either playerOne or PlayerTwo
       public static void PlayGame()
        {
            //initialize variables
            bool ok = true;
            string userName;
            string opponent;
            string oppenentOne = "Ba";
            string opponentTwo = "Te";
            string message = "Welcome to the game! Would you like to play the Barracudas or the Termites (Enter Ba or Te) \n";
         
            //prompt the user to the game
            Console.WriteLine("Welcome to Rock, Paper, Scissors\n");

            //Ask user for their names
            userName = Validator.GetUserInputTwo("Please enter your name\n");

            //Ask the user would they like to play the Barracudas or the Termites
            opponent = Validator.GetChoiceString(oppenentOne, opponentTwo, message);

            //use if else statement to process the game play
            if (opponent == "Ba")
            {
                //call the versusBarracuda Method
                VersusBarracuda(userName);
            }
            else
            {
                //call the versusPlayerTwo method
                VersusTermite(userName);
            }

           
        }
        public static void VersusBarracuda(string userName)
        {
            //initalize variables
            bool ok = true;
            int draw = 0;
            int userWins = 0;
            int barracudaWins = 0;

            Roshambo barracudaChoice;
            //Roshambo playerTwoChoice;
            Roshambo userChoice;

            //create a PlayerOne object
            PlayerOne barracuda = new PlayerOne();

            //create PlayerThree object
            PlayerThree user = new PlayerThree();

            //wrap the code in a while loop
            while (ok)
            {
                //call the generate Roshambo method for player one
                barracudaChoice = barracuda.GetRoshambo();

                userChoice = user.GetRoshambo();

                //determine who won the game
                if (userChoice == Roshambo.Rock && barracudaChoice == Roshambo.Rock)
                {
                    //print out what the players selected and who won game
                    Console.WriteLine(userName + ": " + userChoice);
                    Console.WriteLine("Barracuda: " + barracudaChoice);
                    Console.WriteLine();
                    Console.WriteLine("Draw game");
                    Console.WriteLine();

                    //draw game. Increment draw variable
                    draw++;
                }
                else if (userChoice == Roshambo.Paper && barracudaChoice == Roshambo.Rock)
                {
                    //print out what the players selected and who won game
                    Console.WriteLine(userName + ": " + userChoice);
                    Console.WriteLine("Barracuda: " + barracudaChoice);
                    Console.WriteLine();
                    Console.WriteLine(userName + " wins!");
                    Console.WriteLine();

                    //user wins game. Increment user counter
                    userWins++;
                }
                else 
                {
                    //print out what the players selected and who won game
                    Console.WriteLine(userName + ": " + userChoice);
                    Console.WriteLine("Barracuda: " + barracudaChoice);
                    Console.WriteLine();
                    Console.WriteLine("Barracuda wins!");
                    Console.WriteLine();
                    //user chooses scissors. Barracuda chooses Rock. Increment Baracuda win
                    barracudaWins++;
                }

                //propmt the user to go again
                ok = Validator.GetContinue();
                Console.WriteLine();
            }

            //display match results
            Console.WriteLine("Match Results");
            Console.WriteLine("---------------");
            Console.WriteLine(userName + " wins: " + userWins);
            Console.WriteLine("Barracuda wins: " + barracudaWins);
            Console.WriteLine("Draw: " + draw);
        }

        public static void VersusTermite(string userName)
        {
            //initalize variables
            bool ok = true;
            int draw = 0;
            int userWins = 0;
            int termiteWins = 0;

            Roshambo termiteChoice;
            //Roshambo playerTwoChoice;
            Roshambo userChoice;

            //create a PlayerOne object
            PlayerTwo termite = new PlayerTwo();

            //create PlayerThree object
            PlayerThree user = new PlayerThree();

            //wrap the code in a while loop
            while (ok)
            {
                //call the generate Roshambo method for player one
                termiteChoice = termite.GetRoshambo();

                userChoice = user.GetRoshambo();

                //determine who won the game
                if (userChoice == Roshambo.Rock && termiteChoice == Roshambo.Rock)
                {
                    //print out what the players selected and who won game
                    Console.WriteLine(userName + ": " + userChoice);
                    Console.WriteLine("Termite: " + termiteChoice);
                    Console.WriteLine();
                    Console.WriteLine("Draw game");
                    Console.WriteLine();
                    //draw game. Increment draw variable
                    draw++;
                }
                else if (userChoice == Roshambo.Paper && termiteChoice == Roshambo.Paper)
                {
                    //print out what the players selected and who won game
                    Console.WriteLine(userName + ": " + userChoice);
                    Console.WriteLine("Termite: " + termiteChoice);
                    Console.WriteLine();
                    Console.WriteLine("Draw game");
                    Console.WriteLine();
                 
                    //draw game
                    draw++;
                }
                else if (userChoice == Roshambo.Scissors && termiteChoice == Roshambo.Scissors)
                {
                    //print out what the players selected and who won game
                    Console.WriteLine(userName + ": " + userChoice);
                    Console.WriteLine("Termite: " + termiteChoice);
                    Console.WriteLine();
                    Console.WriteLine("Draw game");
                    Console.WriteLine();

                    //draw game
                    draw++;
                }
                else if (userChoice == Roshambo.Rock && termiteChoice == Roshambo.Paper)
                {
                    //print out what the players selected and who won game
                    Console.WriteLine(userName + ": " + userChoice);
                    Console.WriteLine("Termite: " + termiteChoice);
                    Console.WriteLine();
                    Console.WriteLine("Termite wins game!");
                    Console.WriteLine();

                    //termite wins game. Increment termite counter
                    termiteWins++;
                }
                else if (userChoice == Roshambo.Scissors && termiteChoice == Roshambo.Rock)
                {
                    //print out what the players selected and who won game
                    Console.WriteLine(userName + ": " + userChoice);
                    Console.WriteLine("Termite: " + termiteChoice);
                    Console.WriteLine();
                    Console.WriteLine("Termite wins game!");
                    Console.WriteLine();

                    //termite wins game. Increment termite counter
                    termiteWins++;
                }
                else if (userChoice == Roshambo.Paper && termiteChoice == Roshambo.Scissors)
                {
                    //print out what the players selected and who won game
                    Console.WriteLine(userName + ": " + userChoice);
                    Console.WriteLine("Termite: " + termiteChoice);
                    Console.WriteLine();
                    Console.WriteLine("Termite wins game!");
                    Console.WriteLine();

                    //termite wins game. Increment termite counter
                    termiteWins++;
                }
                else if (userChoice == Roshambo.Rock && termiteChoice == Roshambo.Scissors)
                {
                    //print out what the players selected and who won game
                    Console.WriteLine(userName + ": " + userChoice);
                    Console.WriteLine("Termite: " + termiteChoice);
                    Console.WriteLine();
                    Console.WriteLine(userName + " wins game!");
                    Console.WriteLine();

                    //user wins game. Increment termite counter
                    userWins++;
                }
                else if (userChoice == Roshambo.Paper && termiteChoice == Roshambo.Rock)
                {
                    //print out what the players selected and who won game
                    Console.WriteLine(userName + ": " + userChoice);
                    Console.WriteLine("Termite: " + termiteChoice);
                    Console.WriteLine();
                    Console.WriteLine(userName + " wins game!");
                    Console.WriteLine();

                    //user wins game. Increment termite counter
                    userWins++;
                }
                else if (userChoice == Roshambo.Scissors && termiteChoice == Roshambo.Paper)
                {
                    //print out what the players selected and who won game
                    Console.WriteLine(userName + ": " + userChoice);
                    Console.WriteLine("Termite: " + termiteChoice);
                    Console.WriteLine();
                    Console.WriteLine(userName + " wins game!");
                    Console.WriteLine();

                    //user wins game. Increment termite counter
                    userWins++;
                }
                //propmt the user to go again
                ok = Validator.GetContinue();
                Console.WriteLine();
            }

            //display match results
            Console.WriteLine("Match Results");
            Console.WriteLine("--------------");
            Console.WriteLine(userName + " wins: " + userWins);
            Console.WriteLine("Termite wins: " + termiteWins);
            Console.WriteLine("Draw: " + draw);
        }

    }
}
