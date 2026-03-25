/* Imagine que você está desenvolvendo um sistema de boletim escolar para uma escola que deseja modernizar sua forma de acompanhar o desempenho dos alunos. 
O objetivo é criar um programa capaz de calcular a média das notas, facilitando o trabalho e fornecendo resultados imediatos.

Para essa atividade, você deve criar um programa que:

Declare três variáveis do tipo float para armazenar as notas dos alunos. Foi fornecido pela escola os seguintes valores (7.2, 8.3 e 9.1)
Calcule a média aritmética das três.
Exiba a média calculada.
Saída esperada:

A média das notas é: 8,2  */

float nota1 = 7.2f;
float nota2 = 8.3f;
float nota3 = 9.1f;
float media = (nota1 + nota2 + nota3) / 3.0f;
//float media = (7.2f + 8.3f + 9.1f) / 3.0f;
Console.WriteLine($"A média das notas é: {media}");