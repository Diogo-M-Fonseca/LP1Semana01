﻿using System;
using System.Globalization;
using System.Text;



namespace Smiley
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere código:");
            string read = Console.ReadLine();
            int conv = int.Parse(read);
            Console.OutputEncoding=Encoding.UTF8;
            string asw = char.ConvertFromUtf32(conv);
            Console.WriteLine(asw);

        }
    }
}
