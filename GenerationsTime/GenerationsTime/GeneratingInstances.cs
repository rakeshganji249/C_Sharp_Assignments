using System;

namespace GenerationsTime
{
    /// <summary>
    /// Calculates the time to move between Gen0 to Gen1 and Gen1 to Gen2
    /// </summary>
    internal class GeneratingInstances
    {
        /// <summary>
        /// check the time taken for an object named instance to move between Generations.
        /// </summary>
        public void GenerateObjects()
        {
            //Instance is created for GeneratingInstances
            GeneratingInstances instance = new ();

            DateTime startTime1 = DateTime.Now;

            // Gen0 - Gen1
            CreateInstanceForGen1(instance);

            TimeSpan creationTime1 = DateTime.Now - startTime1;

            Console.WriteLine($"Time taken for object obj to move from Gen0 to Gen1: {creationTime1.TotalMilliseconds} ms");

            DateTime startTime2 = DateTime.Now;

            // Gen1 - Gen2
            CreateInstanceForGen1(instance);

            TimeSpan creationTime2 = DateTime.Now - startTime2;

            Console.WriteLine($"Time taken for object obj to move from Gen1 to Gen2: {creationTime2.TotalMilliseconds} ms");
        }
        /// <summary>
        /// Demonstrates a loop that creates instances till instance is gone to gen1.
        /// </summary>
        /// <param name="instance">Object to check in whicjh generation is present</param>
        public void CreateInstanceForGen1(object  instance)
        {
            while (GC.GetGeneration(instance) != 1)
            {
                GeneratingInstances instanceA = new();
                GeneratingInstances instanceB = new();
                GeneratingInstances instanceC = new();
            }
        }
        public void CreateInstanceForGen2(object instance)
        {
            while (GC.GetGeneration(instance) != 2)
            {
                GeneratingInstances instanceA = new();
                GeneratingInstances instanceB = new();
                GeneratingInstances instanceC = new();

            }
        }
    }
}
