using System;

namespace FloatToBinaryAndSum
{

    class Program
    {
        static void Main(string[] args)
        {
            FloatToBinaryConversionCall binaryConverter = new FloatToBinaryConversionCall();

            Console.Write("Enter a first float number : ");

            float floatValueOne = float.Parse(Console.ReadLine());

            Console.Write("Enter a second float number : ");

            float floatValueSecond = float.Parse(Console.ReadLine());

            string floatToBinaryFirstVal;

            string floatToBinarySecondVal;

            string binFloatmntcFirst, binFloatmntcSecond;

            string paddedBinary1, paddedBinary2;

            binaryConverter.ConvertFloatToBinaryNumber(floatValueOne, out floatToBinaryFirstVal, out binFloatmntcFirst);

            binaryConverter.ConvertFloatToBinaryNumber(floatValueSecond, out floatToBinarySecondVal, out binFloatmntcSecond);

            Console.WriteLine("Enter a first Binary float number : " + floatToBinaryFirstVal);

            Console.WriteLine("Enter a second Binary float number : " + floatToBinarySecondVal);

            binaryConverter.PadZeros(binFloatmntcFirst, binFloatmntcSecond, out paddedBinary1, out paddedBinary2);

            string binaryAddedNumber = binaryConverter.AddBinary(paddedBinary1, paddedBinary2);

            int maxLength = Math.Max(binFloatmntcFirst.Length, binFloatmntcSecond.Length);

            string[] binaryAddedNumberParts = binaryConverter.PointDivide(binaryAddedNumber);

            string binaryAddedNumberPartsOne = binaryAddedNumberParts[0];

            string binaryAddedNumberPartstwo = binaryAddedNumberParts[1];

            int DecimalbeforePoint = binaryConverter.ConvertBinaryToDecimal(binaryAddedNumberPartsOne);

            double DecimalAfterPoint = binaryConverter.ConvertMantissaToDecimal(binaryAddedNumberPartstwo);

            double AddedNumber = DecimalbeforePoint + DecimalAfterPoint;

            Console.WriteLine(AddedNumber);

        }

    }

}
