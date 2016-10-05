using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {  
           
        static void Main(string[] args)
        {
            //string myString = "Go to your c:\\ drive";    //escape keys 1, 2, and 3 ex
            //string myString = "My \"so called\" life";
            //string myString = "What if I need \n a new line?";

            // string myString = string.Format("{0}!", "Bonzai");       //substitutions
            string myString = string.Format("Make: {0} (Model: {1})","BMW", "760li");

            Console.WriteLine(myString);
            Console.ReadLine();  
        }
    }
}
