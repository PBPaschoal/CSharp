/* Você está desenvolvendo um conversor de temperatura que permite ao usuário escolher entre duas opções: 
converter de Celsius para Fahrenheit ou de Fahrenheit para Celsius. 
O programa deve exibir um menu com essas opções e repetir até que o usuário escolha sair.

Para isso, você precisará de um programa que:

    Exiba um menu com as opções de conversão e saída.
    Permita ao usuário escolher uma das opções.
    Exiba uma mensagem de Operação inválida caso escolhido uma opção que não existe.
    Realize a conversão de temperatura com base na escolha do usuário.
    Repita o menu até que o usuário escolha sair.

Dicas:

    Fórmula para conversão de Celsius para fahrenheit: (celsius * 9 / 5) + 32
    Fórmula para conversão de fahrenheit para Celsius: (fahrenheit - 32) * 5 / 9

Exemplo de entrada:

1 - Celsius para Fahrenheit
2 - Fahrenheit para Celsius
3 - Sair
Escolha uma opção: 1
Digite a temperatura em Celsius: 25

Saída esperada:

25°C equivalem a 77°F */
int escolha;
string texto = "Digite a temperatura em ";
do {
    Console.WriteLine("1 - Celsius para Fahrenheit\n2 - Fahrenheit para Celsius\n3 - Sair");
    escolha = int.Parse(Console.ReadLine());
    switch(escolha) {
        case 1:
            Console.WriteLine("Convertendo Celsius para Fahrenheit: ");
            Console.Write($"{texto} Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.Clear();
            Console.WriteLine($"{celsius}ºC equivalem a {fahrenheit}ºF\n");
            break;
        case 2:
            Console.WriteLine("Convertendo Fahrenheit para Celsius:");
            Console.Write($"{texto} Fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.Clear();
            Console.WriteLine($"{fahrenheit}ºF equivalem a {celsius}ºC\n");
            break;
        case 3:
            Console.WriteLine("Encerrando o programa.\n");
            break;
        default:
            Console.WriteLine("Opção inválida.\n");
            break;
    }  
} while(escolha != 3);