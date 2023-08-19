using System;
using FloatTobinaryAndSum;
using FoatToBinaryConvertAndAdd;


namespace FloatToBinaryConversionAndSum
{

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the FloatToBinaryConversionCall class
            FloatToBinaryConversionCall binaryConverter = new FloatToBinaryConversionCall();

            // Prompting user to input two float numbers
            Console.Write("Enter a first float number : ");

            float floatValueOne = float.Parse(Console.ReadLine());

            Console.Write("Enter a second float number : ");

            float floatValueSecond = float.Parse(Console.ReadLine());

            // Variables to store the binary representations of input float values
            string floatToBinaryFirstVal;

            string floatToBinarySecondVal;

            // Variables to store binary mantissas of the float values
            string binFloatmntcFirst, binFloatmntcSecond;

            // Padding binary mantissas to equal lengths
            string paddedBinary1, paddedBinary2;

           // Converting the input float values to binary and extracting their mantissas
            binaryConverter.ConvertFloatToBinaryNumber(floatValueOne, out floatToBinaryFirstVal, out binFloatmntcFirst);

            binaryConverter.ConvertFloatToBinaryNumber(floatValueOne, out floatToBinarySecondVal, out binFloatmntcSecond);

            Console.WriteLine("Enter a first Binary float number : " + floatToBinaryFirstVal);

            Console.WriteLine("Enter a second Binary float number : " + floatToBinarySecondVal);

            binaryConverter.PadZeros(binFloatmntcFirst, binFloatmntcSecond, out paddedBinary1, out paddedBinary2);

            // Adding the padded binary numbers
            string BinaddedNum = binaryConverter.AddBinary(paddedBinary1, paddedBinary2);

            int maxLength = Math.Max(binFloatmntcFirst.Length, binFloatmntcSecond.Length);

            // Splitting the binary sum into integer and fractional parts
            string[] BinaddedNumParts = binaryConverter.PointDivide(BinaddedNum);

            string BinaddedNumParts1 = BinaddedNumParts[0];

            string BinaddedNumParts2 = BinaddedNumParts[1];

            // Converting binary integer part to decimal
            int DecimalbeforePoint = binaryConverter.ConvertBinaryToDecimal(BinaddedNumParts1);

            // Converting binary fractional part to decimal
            double DecimalAfterPoint = binaryConverter.ConvertMantissaToDecimal(BinaddedNumParts2);

            // Calculating the final sum of the two binary float values
            double AddedNum = DecimalbeforePoint + DecimalAfterPoint;

            // Displaying the final sum
            Console.WriteLine(AddedNum);

        }

    }

}
