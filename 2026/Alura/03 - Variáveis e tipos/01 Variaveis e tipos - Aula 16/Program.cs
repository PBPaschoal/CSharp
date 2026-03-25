/* Você trabalha para uma empresa de engenharia que desenvolve soluções para cálculos geométricos utilizados em projetos de construção e design. 
Um dos clientes da empresa solicitou um sistema para calcular a área e o perímetro (também conhecido como circunferência) de círculos, informações essenciais para o planejamento de estruturas circulares, como tanques, pisos e jardins.

Sua missão é criar um programa que, a partir do raio de um círculo, calcule sua área e perímetro utilizando as fórmulas matemáticas adequadas.

Crie um programa que:

Declare uma variável que receba o valor de PI (considere PI como sendo igual a 3.14159).
Declare uma variável que receba o valor do raio do círculo.
Calcule e armazene em uma variável a área do círculo utilizando a fórmula: área = pi x raio x raio.
Calcule e armazene em uma variável o perímetro do círculo utilizando a fórmula: 2 * pi * raio.
Exiba os resultados no console.
Exemplo de entrada:

double raio = 5.0; 
Saída esperada:

Você pode usar o método .ToString("F2") para formatar a saída dos valores no console, por exemplo: raio.ToString("F2")

Raio: 5,00 
Área do círculo: 78,54 
Perímetro do círculo: 31,42  */

//double pi = 3.14159;
double raio = 5.0;
double area = Math.PI * Math.Pow(raio, 2);
double perimetro = 2 * Math.PI * raio;
Console.WriteLine($"Raio: {raio.ToString("F2")}");
Console.WriteLine($"Área do círculo: {area.ToString("F2")}");
Console.WriteLine($"Perímetro do cículo: {perimetro.ToString("F2")}");