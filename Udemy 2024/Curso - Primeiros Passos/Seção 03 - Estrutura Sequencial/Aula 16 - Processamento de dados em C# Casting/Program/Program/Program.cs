using System;

namespace curso { 
    class Program { 
        static void Main(string[] args) {

            int x, y, a, c, be;
            double yp, b, B, h, area, resultado, ah;
            x = 5;
            y = 2 * x;
            yp = 2 * x;

            b = 6.0;
            B = 8.0;
            h = 5.0;

            a = 5;
            c = 2;
            resultado = (double) a / c;

            area = (b + B) / 2.0 * h;

            ah = 5.0;
            be = (int) ah;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(yp);
            Console.WriteLine(area);
            Console.WriteLine(resultado);
            Console.WriteLine(be);

            Console.ReadLine();
        
        }
    }
}