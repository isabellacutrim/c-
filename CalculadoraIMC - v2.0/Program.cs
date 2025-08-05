using System;
using System.Reflection.Emit;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criar um programa que calcule o Índice de Massa Corporal (IMC) e forneça uma análise de saúde com base nos dados do usuário, utilizando todos os conceitos fundamentais de programação.
            //$"IMC: {imc:F2} = apresenta o imc apenas com ate duas casas decimais
            //while (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0)
               //o int.tryParse = converte para int pelo valor lido
               //e ! inverte o resultado 
               //out = modificador de parametro, a variavel esta sendo passada por referencia (false = Armazena o valor convertido na variável out. true = A variável out recebe 0 (valor padrão para int).)


            //metodo de entrada de dados
            
            int idade = 0;
            double altura = 0;
            String nome = "";
            double peso = 0;
            bool consomeAlcool = true , ehFumante = true;
            char opc = 'S';

            //metodo abrir o programa
            Console.WriteLine("=== Calculadora de IMC ===");

            //insirindo informações 
            do {

                //metodo de entrada de dados
                Console.Write("Digite seu nome: ");
                nome = Console.ReadLine()  ?? string.Empty;


                Console.Write("Digite sua idade: ");
                while (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0){
                    Console.WriteLine("Idade incorreta! Digite novamente: ");
                }

                Console.Write("Digite sua altura (m): ");
                while (!double.TryParse(Console.ReadLine(), out altura) || altura <= 0){
                    Console.WriteLine("Altura incorreta! Digite novamente: ");
                }

                Console.Write("Digite seu peso (Kg): ");
                while (!double.TryParse(Console.ReadLine(), out peso) || peso <= 0){
                    Console.WriteLine("Peso incorreto! Digite novamente: ");
                }

                Console.WriteLine("Consome álcool:  Digite 's' para SIM ou 'n' para NÃO");
                char consomeAlcoolSouN = char.Parse(Console.ReadLine()  ?? string.Empty);
                while(consomeAlcool != true && consomeAlcool != false){
                    Console.WriteLine("Digite novamente: ");
                    consomeAlcoolSouN = char.Parse(Console.ReadLine()  ?? string.Empty);
                }
                switch (consomeAlcoolSouN)
                {
                    case 'S':
                    consomeAlcool = true;
                    break;

                    case 'N':
                    consomeAlcool = false;
                    break;
                }
                
                Console.WriteLine("Fumante ativo: Digite 's' para SIM ou 'n' para NÃO");
                char ehFumanteSouN = char.Parse(Console.ReadLine()  ?? string.Empty);
                while(ehFumante != true && ehFumante != false){
                    Console.WriteLine("Digite novamente: ");
                    ehFumanteSouN = char.Parse(Console.ReadLine()  ?? string.Empty);
                }
                switch (ehFumanteSouN)
                {
                    case 'S':
                    ehFumante = true;
                    break;
                    case 'N':
                    ehFumante = false;
                    break;
                }

                Console.WriteLine("Pratica algum esporte ou atividade física?  Digite 's' para SIM ou 'n' para NÃO");
                bool ativoOuSedentario = false;
                char aOuS = char.Parse(Console.ReadLine()  ?? string.Empty);
                while(ativoOuSedentario != true && ativoOuSedentario != false){
                    Console.WriteLine("Digite novamente: ");
                    aOuS = char.Parse(Console.ReadLine()  ?? string.Empty);
                }
                switch (aOuS)
                {
                    case 's':
                    ativoOuSedentario = true;
                    break;
                    case 'n':
                    ativoOuSedentario = false;
                    break;
                }
                
                //metodo do calculo do imc
                //calculo imc = peso / (alturaXaltura)
                double imc = peso / (altura * altura);
                
                //metodo de classificacao de idade
                if (idade <= 12)
                {
                    Console.WriteLine("Criança");
                }
                else if (idade <= 18)
                {
                    Console.WriteLine("Adolescente");
                }
                else if (idade <= 59)
                {
                    Console.WriteLine("Adulto");
                }
                 else 
                {
                    Console.WriteLine("Idoso");
                }

                //metodo de classificacao de imc
                //classificar imc 
                if (imc < 18.5)
                {
                    Console.WriteLine($"IMC: {imc:F2} (Abaixo do peso)");
                    
                }else if(imc >= 18.5 && imc <= 24.9){

                    Console.WriteLine($"IMC: {imc:F2} (Peso normal)");

                }else if (imc >= 25.0 && imc <= 29.9){

                    Console.WriteLine($"IMC: {imc:F2} (Sobrepeso)");

                }
                else if (imc >= 30.0){

                    Console.WriteLine($"IMC: {imc:F2} (Obesidade)");
                }
                if (ehFumanteSouN == 's' && consomeAlcoolSouN == 's'){
                    Console.WriteLine("Risco Maior!");
                }
                if (ativoOuSedentario == false)
                {
                    Console.WriteLine("Se exercite!" + ativoOuSedentario);
                }
                if (imc >= 30 && idade > 50){
                    Console.WriteLine("Risco aumentado para complicações de saúde");
                }
                else if (imc < 18.5){
                    Console.WriteLine("Risco aumentado para complicações de saúde");
                }
                else{
                    Console.WriteLine("Peso dentro da faixa de segurança");
                }
                Console.WriteLine("Deseja calcular novamente? Digite 's' para SIM ou 'n' para NÃO");
                opc = char.Parse(Console.ReadLine()  ?? string.Empty);


                while(opc != 's' && opc != 'n'){
                    Console.WriteLine("Digite novamente: ");
                    opc = char.Parse(Console.ReadLine()  ?? string.Empty);
                }
            }while(opc == 's');
        }
    }
}