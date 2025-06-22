using bulls_and_cows_game;
class Program
{

    static void Main()
    {
        
        for (int i = 0; i < 16; i++)
        {
        
        Game game = new Game();

        Console.WriteLine(game.secretCode);
        }
    }
}