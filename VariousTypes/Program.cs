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
        }
    }
}
