/* Exercício 1016 Distância - Beecrowd 
 * Dois carros (X e Y) partem em uma mesma direção. O carro X sai com velocidade constante de 60 Km/h e o carro Y 
 * sai com velocidade constante de 90 Km/h.
 * 
 * Em uma hora (60 minutos) o carro Y consegue se distanciar 30 quilômetros do carro X, ou seja, consegue se afastar 
 * um quilômetro a cada 2 minutos.
 * 
 * Leia a distância (em Km) e calcule quanto tempo leva (em minutos) para o carro Y tomar essa distância do outro carro.
 * 
 * Entrada
 * O arquivo de entrada contém um número inteiro.
 * 
 * Saída
 * Imprima o tempo necessário seguido da mensagem "minutos".
 * 
 * Exemplo de Entrada	            Exemplo de Saída
 * 30                               60 minutos
 * 
 * 110                              220 minutos
 * 
 * 7                                14 minutos  */

using System;

namespace Program {  
    internal class Program { 
        static void Main(string[] args) {

            // Lê a distância em quilômetros
            int distancia = int.Parse(Console.ReadLine());

            // Velocidade relativa entre os carros em km/h
            int velocidadeRelativa = 90 - 60;

            // Calcula o tempo necessário em minutos
            int tempo = distancia * 60 / velocidadeRelativa;

            // Imprime o resultado
            Console.WriteLine(tempo + " minutos");
        }
    }
}