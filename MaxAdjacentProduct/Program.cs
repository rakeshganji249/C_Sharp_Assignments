﻿using System;
using AdjacentFourdigitProducts;


namespace MaxAdjacentProduct
{
    
    class Program
    {
        /// <summary>
        /// Call the CheckLargestProduct method to check the largest product of adjacent digits in the given input
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();

            AdjacentdigitProduct checkLargestProduct = new AdjacentdigitProduct();

            checkLargestProduct.CheckLargestProduct(input);
        }
    }
}