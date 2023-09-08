namespace FloatToBinaryAndSum
{
    /// <summary>
    /// This class provides methods for converting a floating-point value to its binary representation, manipulating the binary parts, and preparing them for binary floating-point arithmetic.
    /// </summary>
    internal class FloatToBinaryConversion
    {
        /// <summary>
        /// Divides a floating-point value into its integer and fractional parts as strings.
        /// </summary>
        /// <param name="value"></param>
        /// <returns> returnss the substring array</returns>
        public string[] DivideFloatIntoNumberSubParts(float value)
        {
            string[] numberSubParts = new string[2];
            string floatValueAsString = value.ToString();
            string[] subParts = floatValueAsString.Split('.');
            numberSubParts[0] = subParts[0];
            numberSubParts[1] = subParts.Length > 1 ? subParts[1] : "0";
            return numberSubParts;
        }
        /// <summary>
        ///  Converts a decimal integer to its binary representation.
        /// </summary>
        /// <param name="beforePointNumber"></param>
        /// <returns></returns>
        public string ConvertDecimalToBinary(int beforePointNumber)
        {
            if (beforePointNumber == 0)
            {
                return "0";
            }
            string binaryBeforePoint = string.Empty;
            while (beforePointNumber > 0)
            {
                int remainder = beforePointNumber % 2;
                binaryBeforePoint = remainder + binaryBeforePoint;
                beforePointNumber /= 2;
            }
            return binaryBeforePoint;
        }
        /// <summary>
        /// Converts the fractional part of a decimal to its binary representation.
        /// </summary>
        /// <param name="afterPointNumber"></param>
        /// <returns></returns>
        public string Afterpointtobin(int afterPointNumber)
        {
            int duplicateafterPointNumber = afterPointNumber;
            string binaryAfterPoint = String.Empty;
            int lengthOfBinaryAfterPoint = 0;
            while (duplicateafterPointNumber != 0)
            {
                duplicateafterPointNumber = duplicateafterPointNumber / 10;
                lengthOfBinaryAfterPoint++;
            }
            for (int i = 0; i < 23; i++)
            {
                afterPointNumber = afterPointNumber * 2;
                int divisor = (int)Math.Pow(10, lengthOfBinaryAfterPoint);
                if ((afterPointNumber / divisor) == 1)
                {
                    binaryAfterPoint += '1';
                    string valueAfterPointNumber = Convert.ToString(afterPointNumber);
                    string valueAfterPointNumbersub = valueAfterPointNumber.Substring(1, lengthOfBinaryAfterPoint);
                    afterPointNumber = Convert.ToInt32(valueAfterPointNumbersub);
                }
                else
                {
                    binaryAfterPoint += "0";
                }
            }
            return binaryAfterPoint;
        }
        /// <summary>
        ///  Counts the number of binary digits before the decimal point.
        /// </summary>
        /// <param name="binaryBeforePoint"></param>
        /// <returns></returns>
        public int CountOfBinaryBeforeDec(string binaryBeforePoint)
        {
            int NmuberOfBinaryBeforePoint = 0;
            foreach (char c in binaryBeforePoint)
            {
                NmuberOfBinaryBeforePoint++;
            }
            return NmuberOfBinaryBeforePoint;
        }
        /// <summary>
        /// Combines the binary parts (sign, exponent, mantissa) of a floating-point value.
        /// </summary>
        /// <param name="binaryBeforePoint"></param>
        /// <param name="binaryAfterPoint"></param>
        /// <param name="binaryManttace"></param>
        /// <param name="binaryAfterPointManttace"></param>
        public void Changebinbefandaft(string binaryBeforePoint, string binaryAfterPoint, out string binaryManttace, out string binaryAfterPointManttace)
        {
            int NmuberOfBinaryBeforePoint = CountOfBinaryBeforeDec(binaryBeforePoint);
            int exponentnum = NmuberOfBinaryBeforePoint + 127 - 1;
            string binaryExponentum = ConvertDecimalToBinary(exponentnum);
            string beforemanntece = binaryBeforePoint.Substring(1, NmuberOfBinaryBeforePoint - 1);
            binaryManttace = beforemanntece + binaryAfterPoint;
            binaryAfterPointManttace = binaryBeforePoint + binaryAfterPoint;
        }
    }
}
