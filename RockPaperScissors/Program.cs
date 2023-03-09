/*
 * RockPaperScissors
 * To play a game of RPS against the computer
 * 
 * Revision History:
 *     Tony Theo..., 2023.03.08: Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerChoice;
            int computerChoice;
            int playerScore = 0;
            int computerScore = 0;
            string playAgain;

            Random randGen = new Random();

            do
            {
                Console.Clear();

                Console.WriteLine($"Player: {playerScore}  Computer: {computerScore}");
                Console.WriteLine("Please select an option");
                Console.WriteLine("1. Rock");
                Console.WriteLine("2. Paper");
                Console.WriteLine("3. Scissors");

                playerChoice = Convert.ToInt32(Console.ReadLine());
                computerChoice = randGen.Next(1, 4);
                Console.WriteLine($"The computer chose: {computerChoice}");

                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("It's a tie. Play again? (y/n)");
                }
                else if ((playerChoice == 1 && computerChoice == 3) ||
                        (playerChoice == 2 && computerChoice == 1) ||
                        (playerChoice == 3 && computerChoice == 2))
                {
                    playerScore++;
                    Console.WriteLine("You win. Play again (y/n)");
                }
                else
                {
                    computerScore++;
                    Console.WriteLine("You lose. PLay again (y/n)");
                }

                playAgain = Console.ReadLine();

            } while (playAgain == "y");

            Console.ReadKey();

        }
    }
}
