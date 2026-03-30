namespace Janken.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        int playerWins = 0, cpuWins = 0, draws = 0;
        while (true)
        {
            UI.Header();
            UI.Standings(playerWins, cpuWins, draws);
            string result = Game.PlayRound();
            if (result == "win") playerWins++;
            else if (result == "lose") cpuWins++;
            else draws++;

            if (!UI.Retry())
                break;
        }
    }
}
