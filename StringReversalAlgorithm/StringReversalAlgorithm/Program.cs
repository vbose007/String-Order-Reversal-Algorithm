using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReversalAlgorithm
{
    public class Program
    {
        static void Main(string[] args)
        {
            IStringReverseAlgorithm algorithm = new StringReverseAlgorithm();

            Console.WriteLine("\n***********************This program reverses the order of words in a given string***********************");

            Console.Write("\n\nEnter a sentence : ");
            var @string = Console.ReadLine();

            Console.WriteLine($"\n\nReversed sentence: {algorithm.ReverseString(@string)}");

            Console.Read();
        }
    }
}
