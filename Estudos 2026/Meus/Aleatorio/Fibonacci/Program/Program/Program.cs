int a = 0;
int b = 1;
Console.Write("Informe um valor: ");
int qualNumero = int.Parse(Console.ReadLine());
for (int i = 0; i < qualNumero; i++) {
    Console.Write($"{a}, ");
    int temp = a;
    a = b;
    b = temp + a;
}

Console.WriteLine("fim da sequência de Fibonacci!");