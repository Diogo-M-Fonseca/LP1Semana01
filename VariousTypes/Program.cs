using System;

namespace VariousTypes
{
    public class Program
    {
        /// <summary>
        /// Program starts here
        /// Multiple variables being defined and called
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            int numberone = 1;
            int numbertwo = 2;
            int numberfive = 5;

            Console.WriteLine(numberone);
            Console.WriteLine(numbertwo);
            Console.WriteLine(numberfive);

            char star = '\u272D';
            char arrow = '\u2192';
            char infinity = '\u221E';
            
            Console.WriteLine(star);
            Console.WriteLine(arrow);
            Console.WriteLine(infinity);

            float halfone = 0.5f;
            double halfthree = 1.5;
            long longone = 1111111111111L;

            Console.WriteLine(halfone);
            Console.WriteLine(halfthree);
            Console.WriteLine(longone);

            bool correct = 1 < 2;
            bool wrong = 2 < 1;

            Console.WriteLine(correct);
            Console.WriteLine(wrong);
        }
    }
}
