using System;
namespace SingletonDesign
{
    /// <summary>
    /// A sealed class for implementing the Singleton pattern
    /// </summary>
    public sealed class SingletonExample
    {
        private static int instanceCounter = 0;

        private static SingletonExample instance = null;

        /// <summary>
        /// Method to get the Singleton instance
        /// </summary>
        /// <returns>Returns the instance</returns>
        public static SingletonExample GetInstance()
        {
            if (instance == null)
            {
                instance = new SingletonExample();
            }

            return instance;
        }

        /// <summary>
        /// Private constructor to prevent direct instantiation
        /// </summary>
        private SingletonExample()
        {
            instanceCounter++;
            Console.WriteLine("Counter Value " + instanceCounter);
        }

        /// <summary>
        /// Public method to print details using the Singleton instance
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="id"></param>
        /// <param name="role"></param>
        public void PrintUserDetails(string displayName,int id,string role)
        {
            Console.WriteLine("Display Name: " + displayName);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Role: " + role);
        }
        /// <summary>
        /// Public method to convert a float to its IEEE-754 binary representation using Single instance
        /// </summary>
        /// <param name="value"></param>
        public void ConvertFloatToBinary(float value)
        {
            int exponent = 0;
            int powerOfTwo = 1;
            while (powerOfTwo * 2 <= value)
            {
                powerOfTwo *= 2;
                exponent++;
            }
            exponent += 127;
            double mantissa = value / powerOfTwo - 1.0;
            string mantissaBinary = string.Empty;
            for (int i = 0; i < 23; i++)
            {
                mantissa *= 2;
                if (mantissa >= 1)
                {
                    mantissaBinary += "1";
                    mantissa -= 1;
                }
                else
                {
                    mantissaBinary += "0";
                }
            }
            string binaryRepresentation = $"{0}{Convert.ToString(exponent, 2).PadLeft(8, '0')}{mantissaBinary}";

            Console.WriteLine("Binary Representation: " + binaryRepresentation);

        }
    }
}