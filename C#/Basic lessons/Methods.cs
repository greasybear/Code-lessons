using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)   //void here means that the "Main method" is not supposed to return anything 
        {
            // string myValue = superSecretFormula("world");
            string myValue = superSecretFormula("Paul");
            Console.WriteLine(myValue);
            Console.ReadLine();
            
        }

        private static string superSecretFormula()
        {
       
            return "Hello World!";
        }
        private static string superSecretFormula(string name)
        {
            return String.Format("Hey, {0}!", name);
        }
    }
}
