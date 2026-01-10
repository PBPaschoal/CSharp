using System;
using System.Collections.Generic;
class Program {
    public static void Main(string[] args) {
        List<int> numeros = new List<int>{4, 9, 15, 60, 95, 99, 112, 130, 298, 307};
        Console.WriteLine("Com for: ");
        for(int i = 0; i < numeros.Count; i++) {
            if(numeros[i] % 2 == 0) {
                Console.WriteLine(numeros[i] + " é par");
            }
        }
        Console.WriteLine("\nCom foreach: ");
        foreach(int par in numeros) {
            if(par % 2 == 0) {
                Console.WriteLine(par + " é par");
            }
        }
    }
}