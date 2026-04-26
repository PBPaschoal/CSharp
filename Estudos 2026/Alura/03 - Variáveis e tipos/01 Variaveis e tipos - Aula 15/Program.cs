/* Você trabalha desenvolvendo um sistema de recursos humanos para uma empresa. 
Uma das funcionalidades desse sistema é calcular o aumento salarial dos funcionários com base em percentual definido pela empresa. 
Seu desafio é criar um programa que facilite esse cálculo.

Crie um programa que:

Defina uma variável para o salário atual (decimal).
Defina uma variável para o percentual de aumento (decimal).
Calcule o novo salário e o salve em uma nova variável (decimal).
Por fim, exiba o novo salário.
A fórmula para o cálculo é:

salarioAtual + (salarioAtual * percentualAumento / 100) 

Saída esperada:
Você pode usar o método .ToString("F2") para formatar a saída dos valores no console, por exemplo: novoSalario.ToString("F2").
Se o salário atual for de 1500.00 e o percentual de aumento for de 10%, o programa deve exibir:
O novo salário é de R$1650,00 */

decimal salarioAtual = 1500.00m;
decimal percentualAumento = 10.0m;
decimal novoSalario = salarioAtual + (salarioAtual * percentualAumento / 100);
Console.WriteLine($"O novo salário é de R${novoSalario.ToString("F2")}");