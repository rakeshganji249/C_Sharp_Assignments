using System;
namespace GenerationsTime
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            Program obj = new Program();

            //DateTime is an inbuilt function used to measure the timespan of execution process.
            DateTime startTime1 = DateTime.Now;

            //By using getgeneration() inbuilt function to check that object is gone to gen1 in the while loop condition and multiple objects are created.
            while (GC.GetGeneration(obj) != 1)
            {
                Program obj1 = new Program();
                Program obj2 = new Program();
                Program obj3 = new Program();
                
            }
            TimeSpan creationTime1 = DateTime.Now - startTime1;

           
            Console.WriteLine($"Time taken for object obj to move from Gen0 to Gen1: {creationTime1.TotalMilliseconds} ms");

            DateTime startTime2 = DateTime.Now;

            while (GC.GetGeneration(obj) != 2)
            {
                Program obj1 = new Program();
                Program obj2 = new Program();
                Program obj3 = new Program();
                
            }
            TimeSpan creationTime2 = DateTime.Now - startTime2;


            Console.WriteLine($"Time taken for object obj to move from Gen1 to Gen2: {creationTime2.TotalMilliseconds} ms");

        }
    }
}