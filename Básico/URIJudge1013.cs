using System;

namespace URIJudge1013
{
    class URIJudge1013
    {
        static void Main(string[] args)
        {
            int x, y, z, maiorXY, maior;

            string[] valores = Console.ReadLine().Split(' ');
            x = int.Parse(valores[0]);
            y = int.Parse(valores[1]);
            z = int.Parse(valores[2]);

            maiorXY = (x + y + Math.Abs(x - y)) / 2;

            maior = (maiorXY + z + Math.Abs(maiorXY - z)) / 2;

            Console.WriteLine(maior + " eh o maior");
        }
    }
}
