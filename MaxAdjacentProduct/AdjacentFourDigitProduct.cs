using System;

namespace AdjacentFourdigitProducts
{
    /// <summary>
    ///  check and print the largest product of adjacent digits in the given input
    /// </summary>
    internal class AdjacentdigitProduct
    {
        /// <summary>
        /// check the largest product of adjacent digits in the given input string.
        /// </summary>
        /// <param name="input"></param>
        public void CheckLargestProduct(string input)
        {

            // Variables to store the maximum product and the digits that produced it.
            long maxProduct = 0;
            string maxProductDigits = String.Empty;

            // Loop through the input string to find products of adjacent 4 digits.
            for (int i = 0; i <= input.Length - 4; i++)
            {

                long product = 1;
                string currentDigits = "";

                // Loop through the adjacent 4 digits,Convert the character digit to an integer, Multiply the digit with the current product.
                for (int j = i; j < i + 4; j++)
                {

                    int digit = input[j] - '0';

                    product *= digit;

                    currentDigits += digit;

                }

                // Check if the current product is larger than the maximum product found so far.
                if (product > maxProduct)
                {

                    maxProduct = product;
                    maxProductDigits = currentDigits;

                }

            }


            Console.WriteLine($"The maximum product of {maxProductDigits[0]}{maxProductDigits[1]}{maxProductDigits[2]}{maxProductDigits[3]}  is  {maxProduct}");

        }

    }

}

