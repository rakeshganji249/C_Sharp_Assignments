using System;

namespace ScopeOfStaticVariable
{
    /// <summary>
    /// Creates a static Variables and initializes them.
    /// </summary>
    public class Program
    {
        public static int Id;
        public static String UserName;

        /// <summary>
        /// Initializes the static variables and prints them
        /// </summary>
        public static void Main(string[] args)
        {
            Program.Id = 24;
            Program.UserName = "Rakesh";
            Console.WriteLine("satic variables values before modifying from other .cs file is" + Program.Id + Program.UserName);

        }
    }
}