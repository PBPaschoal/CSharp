using System;

namespace Program {

    public class Program {

        public static void Main(string[] args) {

            string[] values = Console.ReadLine().Split(' ');

            int firstValue = int.Parse(values[0]);
            int secondValue = int.Parse(values[1]);
            int thirdValue = int.Parse(values[2]);

            int biggerAB = (firstValue + secondValue + Math.Abs(firstValue - secondValue)) / 2;
            int biggerABC = (biggerAB + thirdValue + Math.Abs(biggerAB - thirdValue)) / 2;

            Console.WriteLine(biggerABC + " eh o maior");
        }
    }
}