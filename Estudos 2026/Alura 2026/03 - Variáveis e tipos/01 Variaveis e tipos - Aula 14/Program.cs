/* Você está desenvolvendo um sistema de controle de vidas para um jogo. 
Nesse jogo, o jogador começa com um número inicial de vidas e, a cada erro, perde uma vida. Por outro lado, ao acertar, ele ganha uma vida.

Seu desafio é criar um programa que simule essa mecânica utilizando os operadores de incremento e decremento. Para isso, o programa deve:

Declarar uma variável com o número inicial de vidas.
Simular uma situação em que o jogador erra.
Simular que o jogador acerta duas vezes.
Armazene o valor final das vidas em uma nova variável.
Saída esperada:

Se o jogador começa com 5 vidas, o programa deve exibir:

Vidas finais: 6 */

int vidas = 5; 
vidas--;  
vidas++; 
vidas++; 
int vidasFinais = vidas; 

Console.WriteLine("Vidas finais: " + vidasFinais); 