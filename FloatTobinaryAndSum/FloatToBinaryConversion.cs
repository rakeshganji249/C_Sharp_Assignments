namespace FloatTobinaryAndSum
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
        public string[] DivideFloatIntoSubstrings(float value)
        {
            string[] substrings = new string[2];

            string floatValueAsString = value.ToString();

            string[] subParts = floatValueAsString.Split('.');

            substrings[0] = subParts[0];

            substrings[1] = subParts.Length > 1 ? subParts[1] : "0";

            return substrings;

        }

        /// <summary>
        ///  Converts a decimal integer to its binary representation.
        /// </summary>
        /// <param name="beforeDecima"></param>
        /// <returns></returns>
        public string ConvertDecimalToBinary(int beforeDecima)
        {

            if (beforeDecima == 0)

                return "0";

            string binbeforedec = string.Empty;

            while (beforeDecima > 0)
            {

                int remainder = beforeDecima % 2;

                binbeforedec = remainder + binbeforedec;

                beforeDecima /= 2;
            }
            return binbeforedec;
        }
        /// <summary>
        /// Converts the fractional part of a decimal to its binary representation.
        /// </summary>
        /// <param name="afterDecimal"></param>
        /// <returns></returns>
        public string Afterpointtobin(int afterDecimal)
        {

            int reafterDecimal = afterDecimal;

            string binAfterDec = String.Empty;

            int lengthofbd = 0;

            while (reafterDecimal != 0)
            {

                reafterDecimal = reafterDecimal / 10;

                lengthofbd++;
            }

            for (int i = 0; i < 23; i++)
            {

                afterDecimal = afterDecimal * 2;

                int divisor = (int)Math.Pow(10, lengthofbd);
                if ((afterDecimal / divisor) == 1)
                {
                    binAfterDec += '1';

                    string strafterDecimal = Convert.ToString(afterDecimal);

                    string strafterDecimalsub = strafterDecimal.Substring(1, lengthofbd);

                    afterDecimal = Convert.ToInt32(strafterDecimalsub);

                }
                else
                {
                    binAfterDec += "0";
                }

            }
            return binAfterDec;
        }

        /// <summary>
        ///  Counts the number of binary digits before the decimal point.
        /// </summary>
        /// <param name="binbeforedec"></param>
        /// <returns></returns>
        public int CountOfBinaryBeforeDec(string binbeforedec)
        {
            int numofbinbefdc = 0;
            foreach (char c in binbeforedec)
            {

                numofbinbefdc++;

            }

            return numofbinbefdc;
        }

        /// <summary>
        /// Combines the binary parts (sign, exponent, mantissa) of a floating-point value.
        /// </summary>
        /// <param name="binbeforedec"></param>
        /// <param name="binAfterDec"></param>
        /// <param name="binmntc"></param>
        /// <param name="binFloatmntc"></param>
        public void Changebinbefandaft(string binbeforedec, string binAfterDec, out string binmntc, out string binFloatmntc)
        {

            int numofbinbefdc = CountOfBinaryBeforeDec(binbeforedec);

            int exponentnum = numofbinbefdc + 127 - 1;

            string binexponent = ConvertDecimalToBinary(exponentnum);

            string beforemntc = binbeforedec.Substring(1, numofbinbefdc - 1);

            binmntc = beforemntc + binAfterDec;

            binFloatmntc = binbeforedec + binAfterDec;
        }

    }
}


