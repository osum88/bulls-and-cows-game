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


        public Game()
        {
            this.secretCode = GenerateSecreteCode();
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
    }
}
