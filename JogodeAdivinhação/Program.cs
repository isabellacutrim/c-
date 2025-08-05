using System;
using System.Collections.Generic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("===== Iniciando Jogo ======");
                Console.WriteLine("Nivel de dificuldade: \n 1 - iniciante  \n 2 - intermediário \n 3 - avançado \n 4 - só Deus sabe...");

                string opcDificuldade = Console.ReadLine() ?? string.Empty;
                bool sucesso = int.TryParse(opcDificuldade, out int opcDificuldadeint);

                if (!sucesso || opcDificuldadeint < 1 || opcDificuldadeint > 4)
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    continue;
                }

                Random random = new Random();
                int numeroSecreto = random.Next(1, 11);
                List<int> historicoPalpites = new List<int>();
                int num = 0;

                switch (opcDificuldadeint)
                {
                    case 1:
                        Console.WriteLine("Boa sorte!");
                        Console.WriteLine("Insira a quantidade de tentativas:");
                        int quantidade = int.Parse(Console.ReadLine() ?? "0");

                        for (int i = 0; i < quantidade; i++)
                        {
                            Console.WriteLine("Insira o número:");
                            num = int.Parse(Console.ReadLine() ?? "0");
                            historicoPalpites.Add(num);

                            if (numeroSecreto == num)
                            {
                                Console.WriteLine("Acertou!!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Tente novamente!!");
                                if (num > numeroSecreto)
                                {
                                    Console.WriteLine("Dica: O número é menor que " + num);
                                }
                                else if (num < numeroSecreto)
                                {
                                    Console.WriteLine("Dica: O número é maior que " + num);
                                }
                            }
                        }
                        Console.WriteLine("O número era: " + numeroSecreto);
                        break;

                    case 2:
                        Console.WriteLine("Boa sorte em dobro");
                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine("Insira o número:");
                            num = int.Parse(Console.ReadLine() ?? "0");

                            if (numeroSecreto == num)
                            {
                                Console.WriteLine("Acertou!!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Tente novamente!!");
                                if (num > numeroSecreto)
                                {
                                    Console.WriteLine("Dica: O número é menor que " + num);
                                }
                                else if (num < numeroSecreto)
                                {
                                    Console.WriteLine("Dica: O número é maior que " + num);
                                }
                            }
                        }
                        Console.WriteLine("O número era: " + numeroSecreto);
                        break;

                    case 3:
                        Console.WriteLine("Boa sorte em triplo");
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine("Insira o número:");
                            num = int.Parse(Console.ReadLine() ?? "0");

                            if (numeroSecreto == num)
                            {
                                Console.WriteLine("Acertou!!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Tente novamente!!");
                                if (num > numeroSecreto)
                                {
                                    Console.WriteLine("Dica: O número é menor que " + num);
                                }
                                else if (num < numeroSecreto)
                                {
                                    Console.WriteLine("Dica: O número é maior que " + num);
                                }
                            }
                        }
                        Console.WriteLine("O número era: " + numeroSecreto);
                        break;

                    case 4:
                        Console.WriteLine("Boa sorte e muita em!");
                        Console.WriteLine("Insira o número:");
                        num = int.Parse(Console.ReadLine() ?? "0");

                        if (numeroSecreto == num)
                        {
                            Console.WriteLine("Acertou!!");
                        }
                        else
                        {
                            Console.WriteLine("Errou! O número era: " + numeroSecreto);
                            if (num > numeroSecreto)
                                {
                                    Console.WriteLine("Dica: O número é menor que " + num);
                                }
                                else if (num < numeroSecreto)
                                {
                                    Console.WriteLine("Dica: O número é maior que " + num);
                                }
                        }
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.WriteLine("Deseja jogar novamente? (s/n)");
                string continuar = Console.ReadLine()?.ToLower() ?? "n";
                if (continuar != "s") break;

            } while (true);
        }
    }
}