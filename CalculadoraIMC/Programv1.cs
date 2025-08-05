using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //jogo de palpite = escolhe um numero se for parecido com o que esta armazenado ganha, tem certas tentativas, nivel de dificuldade e tem dicas

            
            //aramezena o palpites em uma lista 

            int tentaivas = 0;
           
            do{
                Console.WriteLine("===== Iniciando Jogo ======");
                Console.WriteLine("Nivel de dificuldade: \n 1 - iniciante  \n 2 - intermediário \n 3 - avançado \n 4 - só Deus sabe...");
                String opcDificuldade =  Console.ReadLine() ?? string.Empty;
                int opcDificuldadeint;
                int.TryParse(opcDificuldade, out opcDificuldadeint);
                Random random = new Random();
                int numeroSecreto = random.Next(1, 101);
                List<int> historicoPalpites = new List<int>(); 
                int num = 0;
                switch (opcDificuldadeint)
                {
                    case 1:
                        Console.WriteLine("Boa sorte!"); 
                        Console.WriteLine("insira a quantidade de tentativas: "); 
                        int quantidade = int.Parse(Console.ReadLine()  ?? string.Empty);

                        for (int i = quantidade; i > 0; i--)
                        {
                            Console.WriteLine("insira o número"); 
                            num = int.Parse(Console.ReadLine()  ?? string.Empty);
                            historicoPalpites.Add(numeroSecreto);
                            if(numeroSecreto == num){
                                Console.WriteLine("Acertou!!"); 
                            }
                            if (quantidade == 0){
                                Console.WriteLine("acabou as tentativas!!");
                                Console.WriteLine("O número era: " + numeroSecreto); 
                            }
                            // if (quantidade > 0){
                            //     Console.WriteLine("Tente novamente!!"); 
                            // }
                            
                        }
                        break;
                    case 2: 
                        Console.WriteLine("Boa sorte em dobro"); 
                        Console.WriteLine("Quantidade de tentativas: 4"); 
                        for (int i = 4; i > 0; i--)
                        {
                            Console.WriteLine("insira o número"); 
                            num = int.Parse(Console.ReadLine()  ?? string.Empty);
                            if(numeroSecreto == num){
                                Console.WriteLine("Acertou!!"); 
                            }
                            else{
                                Console.WriteLine("Tente novamente!!"); 
                                Console.WriteLine("insira o número"); 
                                num = int.Parse(Console.ReadLine()  ?? string.Empty);
                            }
                            
                        }
                        break;
                    case 3: 
                        Console.WriteLine("Boa sorte em triplo"); 
                        Console.WriteLine("Quantidade de tentativas: 3"); 

                        for (int i = 3; i > 0; i--)
                        {
                            Console.WriteLine("insira o número"); 
                            num = int.Parse(Console.ReadLine()  ?? string.Empty);
                            if(numeroSecreto == num){
                                Console.WriteLine("Acertou!!"); 
                            }
                            else{
                                Console.WriteLine("Tente novamente!!"); 
                                Console.WriteLine("insira o número"); 
                                num = int.Parse(Console.ReadLine()  ?? string.Empty);
                            }
                            
                        }
                        
                        break;
                    case 4: 
                        Console.WriteLine("Boa sorte e muita em!"); 
                        Console.WriteLine("insira a quantidade de tentativas: 1"); 

                        Console.WriteLine("insira o número"); 
                            num = int.Parse(Console.ReadLine()  ?? string.Empty);
                            if(numeroSecreto == num){
                                Console.WriteLine("Acertou!!"); 
                            }
                            else{
                                Console.WriteLine("Tente novamente!!"); 
                                Console.WriteLine("insira o número"); 
                                num = int.Parse(Console.ReadLine()  ?? string.Empty);
                            } 
                        break;
                    default:
                        break;
                }
            }while (tentaivas > 0);
        }
    }
}