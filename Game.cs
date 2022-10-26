using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace KrokodilleSpill
{
    internal class Game
    {
        public static int Score = 0;
        public static void StartGame()
        {
            string playerInput = Console.ReadLine();
            if (playerInput == "<")// Less than
            {
                if(DrawGame.Tall1 < DrawGame.Tall2)
                {
                    Console.WriteLine("Correct! \n" + DrawGame.Tall1 + " is less than " + DrawGame.Tall2);
                    ScoreFunc(0);
                }
                else
                {
                    Console.WriteLine("WRONG ANSWER! TRY AGAIN!");
                    ScoreFunc(1);
                    StartGame();
                }
            }
            else if (playerInput == ">")// Bigger than
            {
                if (DrawGame.Tall1 > DrawGame.Tall2)
                {
                    Console.WriteLine("Correct! \n" + DrawGame.Tall1 + " is bigger than " + DrawGame.Tall2);
                    ScoreFunc(0);
                }
                else
                {
                    Console.WriteLine("WRONG ANSWER! TRY AGAIN!");
                    ScoreFunc(1);
                    StartGame();
                }
            }
            else if (playerInput == "=")// Equal to
            {
                if (DrawGame.Tall1 == DrawGame.Tall2)
                {
                    Console.WriteLine("Correct answer!");
                    ScoreFunc(0);
                }
                else
                {
                    Console.WriteLine("WRONG ANSWER! TRY AGAIN!");
                    ScoreFunc(1);
                    StartGame();
                }
            }
            else
            {
                Console.WriteLine("Not a valid input");
                StartGame();
            }
            PlayAgain();
        }
        private static void PlayAgain()
        {
            Console.WriteLine("Play again? Y/N?");
            string answer = Console.ReadLine().ToLower();
            if(answer == "y")
            {
                DrawGame.DrawBoard();
                StartGame();
            }
            else if (answer == "n")
            {
                Environment.Exit(0);
            }
            PlayAgain();

        }
        private static void ScoreFunc(int n)
        {
            if (n == 0)
            {
                Score++;
            }
            else
            {
                Score--;
            }
            Console.WriteLine("Din score er: " + Score);
        }
    }
}
