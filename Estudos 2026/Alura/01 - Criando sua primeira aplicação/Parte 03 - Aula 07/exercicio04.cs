using System;
using System.Collections.Generic;

class Program {
    public static void Main(string[] args) {
        List<int> valores = new List<int> { 5, 33, 105, 95, 65, 80 };
        int total = 0;
        foreach (int valor in valores) {
            total += valor;
        }
        Console.WriteLine($"Total da soma: {total}");
    }
}
