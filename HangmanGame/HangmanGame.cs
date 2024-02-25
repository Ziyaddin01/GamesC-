using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{

    public class HangmanGame
    {
        private readonly int allowedMisses;
        private bool[] openIndexes;
        private int triesCounter = 0;
        private string triedLetters;

        public GameStatus GameStatus { get; private set; } = GameStatus.NotStarted;

        public string Word { get; private set; }

        public string TriedLetters
        {
            get
            {
                var chars = triedLetters.ToCharArray();
                Array.Sort(chars);
                return new string(chars);
            }
        }
         
        public HangmanGame(int allowedMisses = 6)
        {
            if(allowedMisses < 5 | allowedMisses > 8)
            {
                throw new ArgumentException("Number of allowed misses should be between 5 and 8");
            }
            this.allowedMisses = allowedMisses;
        }
         
        public string GenerateWord()
        {

        }
    }
}
