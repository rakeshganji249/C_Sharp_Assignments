
using System;

namespace DataTypes
{
    struct Bool
    {
        public bool a;
    }
    class DataTypes
    {
        

        public static void Main()
        {
            unsafe
            {
                Bool b = new Bool();
                int s = sizeof(Bool);
                Console.WriteLine(s);
            }

        }
    }
}