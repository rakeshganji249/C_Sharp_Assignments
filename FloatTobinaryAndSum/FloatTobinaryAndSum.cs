using FloatTobinaryAndSum;


namespace FoatToBinaryConvertAndAdd
{

    /// <summary>
    /// This class provides methods to convert float values to their binary representation, perform binary addition,and manipulate the binary parts for binary floating-point arithmetic.
    /// </summary>
    public class FloatToBinaryConversionCall
    {

        /// <summary>
        ///  Converts a float value to its binary representation and extracts the binary mantissa.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="binaryFloatNumber"></param>
        /// <param name="binFloatmntc"></param>
        public void ConvertFloatToBinaryNumber(float value, out string binaryFloatNumber, out string binFloatmntc)
        {

            string binmntc;

            FloatToBinaryConversion binaryConversion = new();

            string[] substrings = binaryConversion.DivideFloatIntoSubstrings(value);

            string beforeDecimal = substrings[0];

            string afterDecimal = substrings[1];

            int beforeDeciamlint = Convert.ToInt32(substrings[0]);

            int afterDeciamlint = Convert.ToInt32(substrings[1]);

            string binbeforedec = binaryConversion.ConvertDecimalToBinary(beforeDeciamlint);

            string binAfterDec = binaryConversion.Afterpointtobin(afterDeciamlint);

            binaryConversion.Changebinbefandaft(binbeforedec, binAfterDec, out binmntc, out binFloatmntc);

            int numofbinbefdc = binaryConversion.CountOfBinaryBeforeDec(binbeforedec);

            int exponentnum = numofbinbefdc + 127 - 1;

            string binexponent = binaryConversion.ConvertDecimalToBinary(exponentnum);

            binaryFloatNumber = '0' + binexponent + binmntc;

        }

        /// <summary>
        ///  Pads the binary mantissas of two floating-point numbers with zeros to equal lengths.
        /// </summary>
        /// <param name="binFloatmntcFirst"></param>
        /// <param name="binFloatmntcSecond"></param>
        /// <param name="paddedBinary1"></param>
        /// <param name="paddedBinary2"></param>
        public void PadZeros(string binFloatmntcFirst, string binFloatmntcSecond, out string paddedBinary1, out string paddedBinary2)
        {

            int maxLength = Math.Max(binFloatmntcFirst.Length, binFloatmntcSecond.Length);
            int zerosToAddToBinary1 = maxLength - binFloatmntcFirst.Length;

            int zerosToAddToBinary2 = maxLength - binFloatmntcSecond.Length;

            paddedBinary1 = new string('0', zerosToAddToBinary1) + binFloatmntcFirst;

            paddedBinary2 = new string('0', zerosToAddToBinary2) + binFloatmntcSecond;
        }

        /// <summary>
        /// Adds two binary numbers and returns the binary sum.
        /// </summary>
        /// <param name="paddedBinary1"></param>
        /// <param name="paddedBinary2"></param>
        /// <returns></returns>
        public string AddBinary(string paddedBinary1, string paddedBinary2)
        {

            int i = paddedBinary1.Length - 1;      
            // Start iterating from the rightmost bit of a

            int j = paddedBinary2.Length - 1;     
            // Start iterating from the rightmost bit of b

            int carry = 0;            
            // Initialize carry to 0

            string result = "";        
            // Initialize the result string

            // Iterate through the bits of both binary numbers and the carry

            while (i >= 0 || j >= 0 || carry > 0)
            {

                int sum = carry;      
                // Initialize sum with the current carry

                if (i >= 0)
                    sum += paddedBinary1[i] - '0'; 
                // Convert char to int by subtracting '0'

                if (j >= 0)
                    sum += paddedBinary2[j] - '0';  
                // Convert char to int by subtracting '0'

                result = (sum % 2) + result;   
                // Add the current bit to the left of the result

                carry = sum / 2;               
                // Update carry for the next addition


                i--;    
                // Move to the next bit in a

                j--;    
                // Move to the next bit in b

            }

            return result;

        }

        /// <summary>
        /// Divides the binary sum into integer and fractional parts.
        /// </summary>
        /// <param name="BinaddedNum"></param>
        /// <returns></returns>
        public string[] PointDivide(string BinaddedNum)
        {

            string[] BinaddedNumParts = new string[2];

            int length = BinaddedNum.Length - 23;

            BinaddedNumParts[0] = BinaddedNum.Substring(0, length);

            BinaddedNumParts[1] = BinaddedNum.Substring(length);

            return BinaddedNumParts;

        }

        /// <summary>
        /// Converts a binary integer part to decimal.
        /// </summary>
        /// <param name="BinaddedNumParts1"></param>
        /// <returns></returns>
        public int ConvertBinaryToDecimal(string BinaddedNumParts1)
        {
            int decimalValue = 0;

            int binaryLength = BinaddedNumParts1.Length;

            for (int i = binaryLength - 1; i >= 0; i--)
            {

                int digit = BinaddedNumParts1[binaryLength - 1 - i] - '0';

                decimalValue += digit * (int)Math.Pow(2, i);

            }

            return decimalValue;

        }

        /// <summary>
        /// Converts a binary fractional part to decimal.
        /// </summary>
        /// <param name="BinaddedNumParts2"></param>
        /// <returns></returns>
        public double ConvertMantissaToDecimal(string BinaddedNumParts2)
        {

            double decimalValue = 0.0;

            int mantissaLength = BinaddedNumParts2.Length;

            for (int i = 0; i < mantissaLength; i++)
            {

                int digit = BinaddedNumParts2[i] - '0';

                decimalValue += digit * Math.Pow(2, -(i + 1)); // Negative exponent for fractional part

            }
            return decimalValue;

        }

    }

}
