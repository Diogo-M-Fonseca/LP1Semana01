using System;
using System.Globalization;



namespace Smiley
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere código:");
            string read = Console.ReadLine();
            int conv = int.Parse(read);

            string asw = char.ConvertFromUtf32(conv);
            Console.WriteLine(asw);

        }
    }
}
