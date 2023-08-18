using System;
using SubPatternSearch;

namespace SearchingOfPattern
{

    /// <summary>
    /// Takes the input of both Input of strings and calls the CheckPattern method.
    /// </summary>
    class Program
    {

        /// <summary>
        /// Takes the input of InputPattern and SubPattern and calls the CheckPattern method with them as parameters.
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string (S1):");
            string InputPattern = Console.ReadLine();

            Console.WriteLine("Enter the second string (S2):");
            string SubPattern = Console.ReadLine();

            //Creating an instance to the PatternSearch
            PatternSearch patternSearch = new PatternSearch();

            //Calling the method CheckPattern()
            patternSearch.CheckPattern(InputPattern, SubPattern);

        }
    }
}