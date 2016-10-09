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
            //string myString = string.Format("Make: {0} (Model: {1})","BMW", "760li");
            //string myString = string.Format("{0:C}", 123.45);
            //string myString = string.Format("{0:C}", 123456789); // this puts it into $$ format
            //string myString = string.Format("{0:P}", .123); //this is %% format, 
            //string myString = string.Format("Phone Number: {0:(###)-###-#### }", 1234567890);
            /*
            string myString = "";
            for (int i = 0; i < 100; i++)
            {
                //myString = myString + "--" + i.ToString();
                myString += "--" + i.ToString();
            }   */
           /* StringBuilder myString = new StringBuilder();
            
            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }
            */

            string myString = " I would prefer not to ";

            //myString = myString.Substring(0, 7);  //returns specific part of the string
            // myString = myString.ToUpper();    //put in all caps
            //myString = myString.Replace(" ", "--");      //looks for emtpy spaces to replace with...

            myString = String.Format("Length before: {0} -- After: {1}", 
                myString.Length,            // this measures the trim
                myString.Trim().Length);  // this trims spaces before and after char's


            Console.WriteLine(myString);
            Console.ReadLine();  
        }
    }
}
