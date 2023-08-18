using System;

namespace SubPatternSearch
{
    /// <summary>
    /// Searching of the substring in the main string.
    /// </summary>
    internal class PatternSearch
    {
        /// <summary>
        /// Checks for the pattern and its occurences.
        /// </summary>
        /// <param name="InputPattern">The first String.</param>
        /// <param name="SubPattern">The second String.</param>
        public void CheckPattern(string InputPattern, string SubPattern)
        {
            
            Console.Write("Index positions = ");

            int occurrences = GetIndexesOfPattern(InputPattern, SubPattern);

            if (occurrences > 0)
            {

                Console.WriteLine("\nNo. of times occurred = " + occurrences);

            }
            else
            {

                Console.WriteLine("\nThe second string is not a substring of the first string.");

            }

        }

        /// <summary>
        /// Checks for the subpattern is present in the inputpattern .
        /// </summary>
        /// <param name="InputPattern">The first String.</param>
        /// <param name="SubPattern">The second String.</param>
        /// <returns>Number of times subpattern occurered.</returns>
        public int GetIndexesOfPattern(string InputPattern,string SubPattern)
        {
            int occurrences = 0;

            // Iterate through the input pattern to find occurrences of the subpattern.
            for (int i = 0; i <= InputPattern.Length - SubPattern.Length; i++)
            {
                bool isMatch = true;

                // Compare each character of the subpattern with the characters in the input pattern.
                for (int j = 0; j < SubPattern.Length; j++)
                {

                    // If a character doesn't match, the subpattern is not found at this position.
                    if (InputPattern[i + j] != SubPattern[j])
                    {
                        isMatch = false;

                        break;

                    }

                }

                // If isMatch is true, the subpattern is found starting at index i.
                if (isMatch)
                {
                    occurrences++;
                    Console.Write(i + " ");

                }

            }
            return occurrences;
        }

    }

}

