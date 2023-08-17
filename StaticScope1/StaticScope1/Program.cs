using System;




namespace ScopeOfStaticVariable
{
    public class ScopeOfStaticVar
    {
        public static int static_variable;
        public static String static_variable_name;
        public static void Main(string[] args)
        {
            ScopeOfStaticVar.static_variable = 24;
            ScopeOfStaticVar.static_variable_name = "Rakesh";
            Console.WriteLine("satic variables values before modifying from other .cs file is" + ScopeOfStaticVar.static_variable + ScopeOfStaticVar.static_variable_name);

        }
    }
}