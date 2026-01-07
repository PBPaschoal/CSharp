using System;
class Program {
    public static void Main(string[] args) {
        Matematica();
    }

    static void Matematica() {
        float a = 2;
        float b = 4;

        float soma = a + b;
        float subtracao = a - b;
        float divisao = a / b;
        float multiplicacao = a * b;

        Console.WriteLine($"a + b = {soma}");
        Console.WriteLine($"a - b = {subtracao}");
        Console.WriteLine($"a / b = {divisao}");
        Console.WriteLine($"a * b = {multiplicacao}");
    }
}