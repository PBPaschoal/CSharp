/* Você trabalha para uma empresa de turismo que organiza passeios e viagens internacionais. 
Muitos dos destinos oferecidos pela empresa utilizam o sistema imperial de medidas, onde as distâncias são fornecidas em milhas. 
No entanto, os clientes brasileiros estão mais familiarizados com o sistema métrico, que utiliza quilômetros.

Para facilitar a comunicação com os clientes, sua missão é criar um sistema de conversão de distâncias que transforme milhas em quilômetros, utilizando a fórmula:

1 milha = 1.60934 quilômetros. 
Copiar código
Crie um programa que:

Declare uma variável que receba o valor das milhas.
Calcule a distância em quilômetros e armazene o resultado em uma nova variável.
Exiba o resultado no console.
Saída esperada:

10 milhas equivalem a 16,0934 quilômetros. */

double valorMilhas = 12;
double valorKM = valorMilhas * 1.60934;
Console.WriteLine(valorMilhas + " milhas equivalem a " + valorKM + " quilômetros.");