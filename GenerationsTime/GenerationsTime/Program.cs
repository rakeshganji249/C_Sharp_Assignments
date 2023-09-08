using System;

namespace GenerationsTime
{
    class Program
    {
        /// <summary>
        /// Calling the GenerateObjects method using instanceA object of the GeneratingInstances
        /// </summary>
        public static void Main(string[] args)
        {

            GeneratingInstances instanceA = new ();
            instanceA.GenerateObjects();

        }

        
    }
}