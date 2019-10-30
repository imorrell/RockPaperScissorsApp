/*Programmer: Ivoire Morrell
 *Program: Rock, Paper, Sciccors application 
 *Date: 10/30/2019 
 *Description: The rock, paper, sciccors application is 
 *a console game that allows the user to play the classic game 
 *against the computer
 * 
 */

using System;

namespace RockPaperScissorsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //use the RoshamboApp class to call the PlayGame method. This method
            //encapsulates all the code needed to process the application
            RoshamboApp.PlayGame();
            
        }
    }
}
