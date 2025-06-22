using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bulls_and_cows_game
{
    public class Game
    {
        public string secretCode { get; private set; }
        public int guessCount { get; private set; }

        public Game()
        {
            this.secretCode = GenerateSecreteCode();
            this.guessCount = 0;
        }

        private static string GenerateSecreteCode()
        {
            Random rnd = new Random();

            char[] digits = "0123456789".ToCharArray();

            for (int i = digits.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                (digits[i], digits[j]) = (digits[j], digits[i]);
            }

            return new string(digits, 0, 4);
        }

        private void IncrementGuessCount()
        {
            this.guessCount++;
        }

        public void MakeGuess(string guess)
        {
            Console.WriteLine(secretCode);
            if (guess.Length != 4 || !guess.All(char.IsDigit))
            {
                throw new ArgumentException("Guess must be a 4-digit number.", guess);
            }

            IncrementGuessCount();

            int bulls = 0;
            int cows = 0;
            List<char> bullsGuess = new List<char>();

            for (int i = 0; i < 4; i++)
            {
                if (guess[i] == secretCode[i])
                {
                    bulls++;
                    bullsGuess.Add(guess[i]);
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (bullsGuess.Contains(guess[i]))
                {
                    continue; 
                }
                else if (secretCode.Contains(guess[i]))
                {
                    cows++;
                }
            }
            Console.WriteLine($"{bulls} bulls, {cows} cows");
        }
    }
}
