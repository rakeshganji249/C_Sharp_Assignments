using System;

namespace SingletonDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonExample firstEmployee = SingletonExample.GetInstance();
            firstEmployee.PrintUserDetails("Rakesh",249,"ASE");

            SingletonExample secondEmployee = SingletonExample.GetInstance();
            secondEmployee.PrintUserDetails("Ramu", 250, "ASE");

            SingletonExample thirdEmployee = SingletonExample.GetInstance();
            thirdEmployee.PrintUserDetails("Amisha", 253, "ASE");

            SingletonExample fourthEmployee = SingletonExample.GetInstance();
            fourthEmployee.PrintUserDetails("Rakesh", 255, "ASE");

            float floatValue = 123.456f;
            firstEmployee.ConvertFloatToBinary(floatValue);
            Console.ReadLine();
        }
    }
}