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
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        //System.Console.WriteLine("じゃんけんゲームを開始します。");
        Console.WriteLine("Bem vindo ao jogo de pedra, papel e tesoura!\n");
        Console.WriteLine("Aperte ENTER para iniciar...");
        Console.ReadKey();
        Console.ForegroundColor = ConsoleColor.White;
    }
    public static bool Retry()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("\nPressione ENTER para jogar novamente ou qualquer outra tecla para sair");
        ConsoleKeyInfo Continue = Console.ReadKey();
        Console.ForegroundColor = ConsoleColor.White;
        if (Continue.Key != ConsoleKey.Enter)
        {
            Console.WriteLine("\n\nObrigado por jogar! Até a próxima!\n");
            return false;
        }
        return true;
    }
}