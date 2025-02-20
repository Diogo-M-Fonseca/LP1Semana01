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
        }
    }
}
