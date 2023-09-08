using System;

namespace MaxAdjacentProduct
{
    /// <summary>
    ///  check and print the largest product of adjacent digits in the given input
    /// </summary>
    class LargestAdjacentProductChecker
    {
        /// <summary>
        /// check the largest product of adjacent digits in the given input string.
        /// </summary>
        /// <param name="input"></param>
        public void CheckLargestAdjacentProduct(string input)
        {

            long maxProduct = 0;
            string maxProductDigits = String.Empty;

            for (int index = 0; index <= input.Length - 4; index++)
            {

                long product = 1;
                string currentSequence = "";

                for (int innerIndex = index; innerIndex < index + 4; innerIndex++)
                {

                    int digit = input[innerIndex] - '0';

                    product *= digit;

                    currentSequence += digit;

                }

                if (product > maxProduct)
                {
                    maxProduct = product;
                    maxProductDigits = currentSequence;
                }

            }
            Console.WriteLine($"The maximum product of {maxProductDigits[0]}{maxProductDigits[1]}{maxProductDigits[2]}{maxProductDigits[3]}  is  {maxProduct}");
        }
    }
}

