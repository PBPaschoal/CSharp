/* Imagine que você está desenvolvendo um sistema de gerenciamento de carga para um grande centro de distribuição. 
Para otimizar o transporte, a empresa estabeleceu que cada veículo deve transportar exatamente 1 tonelada. 
Seu sistema precisa converter o peso total dos containers para um número inteiro de veículos necessários, descartando qualquer fração decimal (já que um veículo não pode ser alocado para transportar apenas parte da carga).

Seu programa deve:

Receber o peso total em toneladas (decimal)
Converter para inteiro descartando a parte decimal
Exibir a quantidade mínima de veículos necessários
Exemplo de entrada:

decimal pesoContainer = 18.75m; 

Saída esperada:

Veículos necessários: 18  */

decimal totalWeightInTons = 18.75m;
int convert = (int)totalWeightInTons;
Console.WriteLine($"Vaículos necessários: {convert}");