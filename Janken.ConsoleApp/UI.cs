using System.Net;
using System.Runtime.InteropServices;

namespace Janken.ConsoleApp;

public static class UI
{
    public static void Standings(int Wins = 0, int Losses = 0, int Draws = 0)
    {
        Console.WriteLine($"Placar atual: \nJogador: {Wins} \nComputador: {Losses} \nEmpates: {Draws}\n");
    }
    public static void Header()
    {
        Console.Clear();
        //System.Console.WriteLine("じゃんけんゲームを開始します。");
        Console.WriteLine("Bem vindo ao jogo de pedra, papel e tesoura!\n");
        Console.WriteLine("Aperte ENTER para iniciar...");
        Console.ReadKey();
    }

    public static bool Retry()
    {
        Console.WriteLine("Pressione ENTER para jogar novamente ou qualquer outra tecla para sair");
        ConsoleKeyInfo Continue = Console.ReadKey();
        if (Continue.Key != ConsoleKey.Enter)
        {
            Console.WriteLine("\nObrigado por jogar! Até a próxima!");
            return false;
        }
        return true;
    }
}