using System;
using System.Collections.Generic;
using System.Text;

namespace HangmanGame
{
    class Program
    {

        static void Main(string[] args)
        {
            HangmanGame game = new HangmanGame();

            int lettersCount = game.GenerateWord();

            Console.WriteLine($"The word consist of {lettersCount} letters.");
            Console.WriteLine("Try to guess the word.");

            while(game.GameStatus == GameStatus.InProgress)
            {
                Console.WriteLine("Pick a letter");
                char c = Console.ReadLine().ToCharArray()[0];

                string curState = game.GuessLetter(c);
                Console.WriteLine(curState);

                Console.WriteLine($"Remaining tries = {game.RemainingTries}");
                Console.WriteLine($"Tried letters:{game.TriedLetters}");

            }
            if(game.GameStatus == GameStatus.Lost)
            {
                Console.WriteLine("You are hanged.");
                Console.WriteLine($"The word was: {game.Word}");
            }
            else if(game.GameStatus == GameStatus.Won)
            {
                Console.WriteLine("You won!");
            }
            Console.ReadLine();
        }
    }
}
        
