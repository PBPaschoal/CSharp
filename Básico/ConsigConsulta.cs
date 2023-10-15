/* Atualmente trabalho com emprestimo consignado, atendimento ao corretor, dando suporte na parte operacional 
 * dos sistemas de bancos. Para praticar eu fiz a um tempo atras esse mesmo programa em C++ e Java, agora estou
 * fazendo em C# para praticar o básico como utilização de switch, if e else.
 * Futuramente farei uma nova versão desse programa, mais avançado.
 * Criado por: Paulo Bruno Paschoal 
 * Dia 16-07-2020 às 20:20hrs, Rio de Janeiro.
 */

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace ConsigConsultaProgram
{
    class ConsigConsulta
    {
        static void Main(string[] args)
        {
            int vall;
            double brut, comiss, sald, lib, parcl;
            string nom = null, cepf = null;

            Console.WriteLine("Escolha o órgão para cadastramento: "); //Como citado, deve digitar 1, 2 ou 3 para selecionar a opção
            Console.WriteLine("[1] = [INSS]: ");
            Console.WriteLine("[2] = [SIAPE]: ");
            Console.WriteLine("[3] = [EXERCITO]: ");
            vall = int.Parse(Console.ReadLine());
            switch (vall)
            {
                case 1:
                    Console.WriteLine("Você selecionou INSS");
                    comiss = 15;
                    break;
                case 2:
                    Console.WriteLine("Você selecionou SIAPE");
                    comiss = 18;
                    break;
                default:
                    Console.WriteLine("Você selecionou EXERCITO");
                    comiss = 20;
                    break;
            }
            Console.WriteLine("\nEscolha o tipo de operação para cadastramento: ");
            Console.WriteLine("[1] = [NOVO]: ");
            Console.WriteLine("[2] = [REFINANCIAMENTO]: ");
            vall = int.Parse(Console.ReadLine());
            if (vall == 1)
            {
                Console.WriteLine("\n------------------------------");
                Console.WriteLine("CADASTRAMENTO DE OPERAÇÃO NOVA");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Informe o nome do cliente: ");
                nom = (Console.ReadLine());
                Console.WriteLine("Informe o CPF do cliente: ");
                cepf = (Console.ReadLine());
                Console.WriteLine("Informe o valor Bruto: ");
                brut = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Informe o valor da parcela: ");
                parcl = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Informe o prazo: ");
                vall = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("***( RESULTADO DA PROPOSTA )***");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("CLIENTE: " + nom);
                Console.WriteLine("CPF: " + cepf);
                Console.WriteLine("Valor Bruto: " + brut.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Parcela: " + parcl.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Prazo: " + vall);
                Console.WriteLine("Porcentagem da Comissao: " + comiss + "%"); // porcentagem da comissão
                comiss = brut * comiss / 100;
                Console.WriteLine("Valor da Comissao: " + comiss.ToString("F2", CultureInfo.InvariantCulture) + "\n\n"); // valor da comissão a receber

            }
            else {
                Console.WriteLine("\n------------------------------");
                Console.WriteLine("CADASTRAMENTO DE REFINANCIAMENTO");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Informe o nome do cliente: ");
                nom = (Console.ReadLine());
                Console.WriteLine("Informe o CPF do cliente: ");
                cepf = (Console.ReadLine());
                Console.WriteLine("Informe o valor Bruto: ");
                brut = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Informe o valor do Saldo: ");
                sald = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Informe o valor da parcela: ");
                parcl = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Informe o prazo: ");
                vall = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("***( RESULTADO DA PROPOSTA )***");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("CLIENTE: " + nom);
                Console.WriteLine("CPF: " + cepf);
                Console.WriteLine("Valor Bruto: " + brut.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Valor do Saldo: " + sald.ToString("F2", CultureInfo.InvariantCulture));
                lib = brut - sald;
                Console.WriteLine("Prazo: " + vall);
                Console.WriteLine("Valor Liberado: " + lib.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Parcela: " + parcl.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Prazo: " + vall);
                Console.WriteLine("Porcentagem da Comissao: " + (comiss - 3) + "%");
                comiss = (brut - sald) * (comiss - 3) / 100;
                Console.WriteLine("Valor da Comissao: " + comiss.ToString("F2", CultureInfo.InvariantCulture) + "\n\n");
            }
        }
    }
}