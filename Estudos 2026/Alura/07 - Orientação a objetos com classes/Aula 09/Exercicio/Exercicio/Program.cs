/* Você foi contratado(a) para desenvolver um sistema de operações bancárias. Cada conta precisa ter um número e um saldo inicial. E, deve existir um método para realizar depósitos, recebendo o valor a ser depositado como parâmetro.

Crie uma classe chamada ContaBancaria que tenha:

Uma propriedade pública NumeroConta.
Uma propriedade pública Saldo.
Um método Depositar(double valor) que adicione o valor ao saldo existente.
Depois, crie uma instância da classe, realize um depósito e exiba o saldo atualizado.

Exemplo de entrada:

ContaBancaria conta = new ContaBancaria("78901-2", 1000.00);
conta.Depositar(500.00);

Exemplo de saída:

Conta: 78901-2
Saldo atual: R$ 1500,00 */

using System;
using System.Globalization;

ContaBancaria contabanco =  new ContaBancaria("78901-2", 1000.00);
contabanco.Depositar(500.00);
Console.WriteLine($"Conta: {contabanco.NumeroConta}");
Console.WriteLine($"Saldo atual: {contabanco.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");