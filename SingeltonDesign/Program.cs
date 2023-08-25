using System;
using SingletonDesignPattern;
namespace SingletonValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton firstEmployee = Singleton.GetInstance();
            firstEmployee.PrintDetails("Rakesh",249,"ASE");

            Singleton secondEmployee = Singleton.GetInstance();
            secondEmployee.PrintDetails("Ramu", 250, "ASE");

            Singleton thirdEmployee = Singleton.GetInstance();
            thirdEmployee.PrintDetails("Amisha", 253, "ASE");

            Singleton fourthEmployee = Singleton.GetInstance();
            fourthEmployee.PrintDetails("Rakesh", 255, "ASE");

            float floatValue = 123.456f;
            firstEmployee.ConvertFloatToBinary(floatValue);
            Console.ReadLine();
        }
    }
}