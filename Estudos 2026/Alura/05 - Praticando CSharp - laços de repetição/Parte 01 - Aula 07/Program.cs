/* Imagine que uma loja de roupas te contratou para criar um sistema simples que ajude a registrar e somar os valores das vendas diárias. 
A loja não possui um sistema de caixa automatizado, então os funcionários precisam digitar manualmente o valor de cada venda ao final do dia. 
O desafio é criar um programa que permita a entrada desses valores de forma contínua até que o usuário digite "0", indicando que todas as vendas do dia foram registradas.

Crie um programa que:

Solicite ao usuário que digite o valor de cada venda (inteiro).
Enquanto o valor digitado for diferente de “0”, o programa adiciona o valor ao total acumulado. O valor precisa ser solicitado ao menos uma vez antes de verificar se o loop deve continuar ou não.
Quando o usuário digita “0”, o programa encerra o loop e exibe o total de vendas do dia.
Exemplo de entrada:

Digite o valor da venda (ou 0 para encerrar): 15
Digite o valor da venda (ou 0 para encerrar): 20
Digite o valor da venda (ou 0 para encerrar): 25
Digite o valor da venda (ou 0 para encerrar): 30
Digite o valor da venda (ou 0 para encerrar): 0
Copiar código
Saída esperada:

Total de vendas do dia: R$90 */

int venda;
int soma = 0;
do {
    Console.Write("Digite o valor da venda: (ou 0 para encerrar): ");
    venda = int.Parse(Console.ReadLine());
    soma += venda;
} while(venda != 0);
Console.WriteLine($"Toal de vendas do dia: R${soma}");