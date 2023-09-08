using System;

namespace SubString
{
    /// <summary>
    /// Searching of the substring in the main string.
    /// </summary>
    internal class SubStringSearch
    {
        /// <summary>
        /// Checks for the pattern and its occurences.
        /// </summary>
        /// <param name="inputString">The first String.</param>
        /// <param name="subString">The second String.</param>
        public void CheckPattern(string inputString, string subString)
        {
            
            Console.Write("Index positions = ");

            int occurrences = GetIndexesOfPattern(inputString, subString);

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
        /// <param name="inputString">The first String.</param>
        /// <param name="subString">The second String.</param>
        /// <returns>Number of times subpattern occurered.</returns>
        public int GetIndexesOfPattern(string inputString,string subString)
        {
            int occurrences = 0;

            // Iterate through the input pattern to find occurrences of the subpattern.
            for (int index1 = 0; index1 <= inputString.Length - subString.Length; index1++)
            {
                bool isMatch = true;

                // Compare each character of the subpattern with the characters in the input pattern.
                for (int index2 = 0; index2 < subString.Length; index2++)
                {

                    // If a character doesn't match, the subpattern is not found at this position.
                    if (inputString[index1 + index2] != subString[index2])
                    {
                        isMatch = false;

                        break;

                    }

                }

                // If isMatch is true, the subpattern is found starting at index i.
                if (isMatch)
                {
                    occurrences++;
                    Console.Write(index1 + " ");

                }

            }
            return occurrences;
        }

    }

}

