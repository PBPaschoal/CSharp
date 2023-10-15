//Dia 13-07-2021 Rio de Janeiro
//Revisando Exercício URI ONLINE JUDGE
//Exemplo Básico
//Leia 2 valores inteiro e armazene-os nas variáveis A e B. Efetue a soma de A e B atribuindo o seu resultado na variável X.
//Imprima X conforme exemplo apresentado abaixo. Não apresente mensagem alguma além daquilo que está sendo especificado e não esqueça
//de imprimir o fim de linha após o resultado. caso contrário, você receberá "Presentation Error".
//Entrada:
//A entrada contém 2 valores inteiros.
//Saída:
//Imprima a variável X conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade. Obs: O X está em maiúsculo e 
//deve ter espaço antes e um espaço depois do sinal de igualdade.
//Exemplos de Entrada:                              Exemplos de Saída:
//10                                                X = 19
//9

using System;

namespace Revisando1001
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, X;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            X = A + B;

            Console.WriteLine("X = " + X);
        }
    }
}
