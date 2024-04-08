/* Aula 45 Exercício Beecrowd 1134	- Tipo de Combustível
 * Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. 
 * Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim). 
 * Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido). 
 * O programa será encerrado quando o código informado for o número 4.
 * 
 * Entrada
 * A entrada contém apenas valores inteiros e positivos.
 * 
 * Saída
 * Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo.
 * 
 * Exemplo de Entrada	                Exemplo de Saída
 * 8                                    MUITO OBRIGADO
 * 1                                    Alcool: 1
 * 7                                    Gasolina: 2
 * 2                                    Diesel: 0 
 * 2
 * 4  */

using System;

namespace Program { 
    internal class Program { 
        static void Main(string[] args) {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            int tipo;
            tipo = int.Parse(Console.ReadLine());
            while (tipo != 4) {
                if (tipo == 1) {
                    alcool += 1;
                } else if (tipo == 2) {
                    gasolina += 1;
                } else if (tipo == 3) {
                    diesel += 1;
                }
                tipo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}