using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jogo da forca!");

            //jogo onde o usuário deve adivinhar uma palavra
            //o usuário deve adivinhar a palavra letra por letra
            //o usuário tem 3 tentativas para adivinhar a palavra

            //se o usuário adivinhar a palavra, ele ganha
            //se o usuário não adivinhar a palavra, ele perde

            //o usuário deve informar a palavra que ele quer adivinhar
            //o usuário deve informar a quantidade de letras da palavra

            //palavras e quantidade de letras 
            Console.WriteLine("Digite a palavra:");
            string palavra = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Digite a categoria:");
            string categoria = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Digite a quantidade de letras da palavra:");
            int quantidadeLetras = int.Parse(Console.ReadLine()?? string.Empty);
            int opc =0;
            string npalavra;
            Console.Clear();

            //usar um for para passar por cada letra e fazer comparação

            //letra ou palavra 
            Console.WriteLine("categoria: "  + categoria);
            Console.WriteLine("A palavra tem " + quantidadeLetras + " letras.");
            do
            {
                Console.WriteLine("Deseja advinhar a letra ou a palavra?");
                Console.WriteLine("Digite 1 para letra ou 2 para palavra:");
                int opcao = int.Parse(Console.ReadLine() ?? string.Empty);
                char letra = ' ';
                if (opcao == 1)
                {
                    Console.WriteLine("Digite a letra:");
                    letra = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Digite a palavra:");
                    npalavra = Console.ReadLine() ?? string.Empty;

                    if (npalavra.Equals(palavra, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Você acertou a palavra!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Você errou a palavra!");
                        continue;
                    }
                }

                //comparar a letra digitada com a letra da palavra
                char[] arrayDeChars = palavra.ToCharArray();
                //transformar string em cha
                int i = 0;
                //problema esta aqui dentro 
                //objetivo = apresentar somente se o caractere digitado existe na palavra
                do
                {

                    for (i = 0; i <= quantidadeLetras - 1 ; i++)
                    {
                        if (letra == arrayDeChars[i])
                        {
                            Console.WriteLine("Você acertou a letra!");
                        }
                    }
                    //nn esta passando pelo else
                    if (i > quantidadeLetras)
                    {
                        Console.WriteLine("Você errou a letra!");
                    }
                    Console.WriteLine("Deseja advinhar a letra novamente?");
                    Console.WriteLine("Digite 1 para SIM ou 2 para NÃO:");
                    opc = int.Parse(Console.ReadLine() ?? string.Empty);

                } while (opc == 1);
                    Console.WriteLine("Digite a palavra:");
                    npalavra = Console.ReadLine() ?? string.Empty;

                    if (npalavra.Equals(palavra, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Você acertou a palavra!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Você errou a palavra!");
                        continue;
                    }
                
            } while (npalavra == palavra);
        }
    }
}