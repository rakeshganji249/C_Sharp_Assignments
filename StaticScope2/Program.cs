using System;
using ScopeOfStaticVariable;

namespace ScopeOfStaticVariable1
{
    /// <summary>
    /// Accesses the static Variables from ScopeOfStaticVariable and reinitializes them.
    /// </summary>
    public class ScopeofStaticVar1
    {
        public void ModifyingVar()
        {
            Program.Id = 19;
            Program.UserName = "Ramu";
        }

        /// <summary>
        /// Invokes the ModifyingVar() method by  an ScopeOfStaticVariable1 instance and prints the variables with program instance
        /// </summary>
        static void Main(string[] args)
        {
            ScopeofStaticVar1 scopeofStaticVar1 = new ScopeofStaticVar1();
            scopeofStaticVar1.ModifyingVar();
            Console.WriteLine("satic variables values after modifying from other .cs file is" + Program.Id + Program.UserName);



        }
    }
}