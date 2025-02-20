using System;

namespace ManyStrings
{
    public class Program
    {
        /// <summary>
        /// Program Starts here and i define and call many variables
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
           string ola = "Ola";
           string eu = "Eu sou o Diogo\nTenho 18 anos\u0021";

            Console.WriteLine(ola);
            Console.WriteLine(eu);

            int x = 1;
            int y = 2;

            string conta = "a" + 2;
            string contax = "abc" + x;

            string interpolacao = $"valor de x é {x}";
            string interpol = $"{x} mais {y} é igual a {x + y}";
            
            Console.WriteLine(conta);
            Console.WriteLine(contax);
            Console.WriteLine(interpolacao);
            Console.WriteLine(interpol);

            double xx = 1.23456;
            int ii = 19;

            string xx1 = $"{xx:f2}, {xx:p1}";
            string ii1 = $"{ii:x}, {ii:c}";

            Console.WriteLine(xx1);
            Console.WriteLine(ii1);


        }
    }
}
