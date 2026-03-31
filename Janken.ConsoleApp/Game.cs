using System.Security.Cryptography;

namespace Janken.ConsoleApp;

public static class Game
{
        public static string PlayRound()
        {
                while (true)
                {
                        Console.WriteLine("\nEscolha sua jogada: \n1 para pedra; \n2 para papel; \n3 para tesoura; \nou digite a palavra correspondente.  ");
                        string? Play = Console.ReadLine();
                        if (Play == "1" || Play?.ToLower() == "pedra")
                                Console.WriteLine("Você escolheu pedra!");
                        else if (Play == "2" || Play?.ToLower() == "papel")
                                Console.WriteLine("Você escolheu papel!");
                        else if (Play == "3" || Play?.ToLower() == "tesoura")
                                Console.WriteLine("Você escolheu tesoura!");
                        else
                        {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Jogada inválida. Escolha uma opção válida.");
                                Console.ResetColor();
                                continue;
                        }
                        int cpuChoice = RandomNumberGenerator.GetInt32(1, 4);
                        string cpuPlay = cpuChoice switch
                        {
                                1 => "pedra",
                                2 => "papel",
                                3 => "tesoura",
                        };
                        Console.WriteLine($"\nO computador escolheu {cpuPlay}\n");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string result;
                        if (Play == "1" || Play?.ToLower() == "pedra")
                        {
                                if (cpuPlay == "pedra")
                                {
                                        Console.WriteLine("Empate!");
                                        result = "draw";
                                }
                                else if (cpuPlay == "papel")
                                {
                                        Console.WriteLine("Você perdeu!");
                                        result = "lose";
                                }
                                else
                                {
                                        Console.WriteLine("Você ganhou!");
                                        result = "win";
                                }
                        }
                        else if (Play == "2" || Play?.ToLower() == "papel")
                        {
                                if (cpuPlay == "pedra")
                                {
                                        Console.WriteLine("Você ganhou!");
                                        result = "win";
                                }
                                else if (cpuPlay == "papel")
                                {
                                        Console.WriteLine("Empate!");
                                        result = "draw";
                                }
                                else
                                {
                                        Console.WriteLine("Você perdeu!");
                                        result = "lose";
                                }
                        }
                        else // tesoura
                        {
                                if (cpuPlay == "pedra")
                                {
                                        Console.WriteLine("Você perdeu!");
                                        result = "lose";
                                }
                                else if (cpuPlay == "papel")
                                {
                                        Console.WriteLine("Você ganhou!");
                                        result = "win";
                                }
                                else
                                {
                                        Console.WriteLine("Empate!");
                                        result = "draw";
                                }
                        }
                        Console.ResetColor();
                        return result;
                }
        }
}