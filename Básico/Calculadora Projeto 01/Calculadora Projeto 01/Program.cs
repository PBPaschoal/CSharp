using System;

namespace Calculadora_Projeto_01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            // Exibe o título como o aplicativo de calculadora do console C#.
            Console.WriteLine("Calculadora do console em C#\r");
            Console.WriteLine("----------------------------\n");

            while (!endApp)
            {
                // Declare variáveis e defina como vazio.
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                // Peça ao usuário para digitar o primeiro número.
                Console.Write("Digite um número e pressione Enter: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Esta não é uma entrada válida. Por favor insira um valor inteiro: ");
                    numInput1 = Console.ReadLine();
                }

                // Peça ao usuário para digitar o segundo número.
                Console.Write("Digite outro número e pressione Enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Esta não é uma entrada válida. Por favor insira um valor inteiro: ");
                    numInput2 = Console.ReadLine();
                }

                // Peça ao usuário para escolher uma operadora.
                Console.WriteLine("Escolha um operador da seguinte lista:");
                Console.WriteLine("\ta - Adicionar");
                Console.WriteLine("\ts - Subtrair");
                Console.WriteLine("\tm - Multiplicar");
                Console.WriteLine("\td - Dividir");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Esta operação resultará em um erro matemático.\n");
                    }
                    else Console.WriteLine("Seu resultado: {0: 0. ##} \n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ah não! Ocorreu uma exceção ao tentar fazer as contas.\n - Details:" + e.Message);
                }

                Console.WriteLine("------------------------\n");

                // Aguarde a resposta do usuário antes de fechar.
                Console.Write("Pressione 'n' e Enter para fechar o aplicativo ou pressione qualquer outra tecla e Enter para continuar:");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Espaçamento de linha amigável.

            }
            return;
        }
    }
}
