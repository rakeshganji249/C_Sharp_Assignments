using System;

namespace SubString
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
            string inputString = Console.ReadLine();

            Console.WriteLine("Enter the second string (S2):");
            string subString = Console.ReadLine();

            //Creating an instance to the PatternSearch
            SubStringSearch patternSearch = new SubStringSearch();

            //Calling the method CheckPattern()
            patternSearch.CheckPattern(inputString, subString);

        }
    }
}