using System;
using ScopeOfStaticVariable;

namespace ScopeOfStaticVariable1
{
    public class ScopeofStaticVar1
    {
        public void ModifyingVar()
        {
            ScopeOfStaticVar.static_variable = 19;
            ScopeOfStaticVar.static_variable_name = "Ramu";
        }
        static void Main(string[] args)
        {
            ScopeofStaticVar1 scopeofStaticVar1 = new ScopeofStaticVar1();
            scopeofStaticVar1.ModifyingVar();
            Console.WriteLine("satic variables values after modifying from other .cs file is" + ScopeOfStaticVar.static_variable + ScopeOfStaticVar.static_variable_name);



        }
    }
}