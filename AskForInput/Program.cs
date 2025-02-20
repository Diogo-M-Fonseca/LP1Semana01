using System;

namespace AskForInput
{
    public class Program
    {
        /// <summary>
        /// program starts here i ask the user for input
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Console.WriteLine("Inserir um numero inteiro:");

            string read = Console.ReadLine(); // premite ler o input
            int conv = int.Parse(read); // converte str em int

            Console.WriteLine("inserir um numero real:");

            string read1 = Console.ReadLine();
            float conv1 = float.Parse(read1);

            Console.WriteLine($"A soma dos dois numeros é {conv + conv1}");
            


        }
    }
}
