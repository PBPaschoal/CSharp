using System;

namespace URIExercicio1007
{
    class URIJudge1007
    {
        static void Main(string[] args)
        {
            int A, B, C, D, DIF;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            DIF = A * B - C * D;

            Console.WriteLine("DIFERENCA = " + DIF);
        }
    }
}
