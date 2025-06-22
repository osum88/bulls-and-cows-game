using bulls_and_cows_game;
class Program
{

    static void Main()
    {
        
        Game game = new Game();

        while (true)
        {
            string guessResult = Console.ReadLine();
 
            game.MakeGuess(guessResult.ToString());
        }
    }
}