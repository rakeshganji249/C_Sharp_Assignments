
using System;
using System.Threading;
namespace OutParameterBehaviour
{
    class Program
    {
        public int value;
        /// <summary>
        /// Method to check the behaviour of out parameter
        /// </summary>
        /// <param name="value"></param>
        public static void CheckBehaviour(out int value)
        {
            //value = 2;
            Console.WriteLine("method Initiated");
            Thread.Sleep(3000);
            value = 3;
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            Thread thread = new Thread(() => CheckBehaviour(out program.value));
            thread.Start();
            Thread.Sleep(2000);
            Console.WriteLine(program.value);
            thread.Join();

        }
    }
}