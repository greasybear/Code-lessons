using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring value types
            /*      int x;
                    int y;
                    //Declaring values of int's
                    x = 7;
                    y = x + 3;
                    Console.WriteLine(y);
            */
            //string myFirstName;
            //myFirstName = "Andrew";
            //    string myFirstName = "Andrew";

            // var myFirstName = "Andrew";

            int x = 7;
            //string y = "Andrew";
            string y = "5";
            string myFirstTry = x.ToString() + y;

            //int mySecondTry = x + y;

            int mySecondTry = x + int.Parse(y);
            //.Parse is a converting method

            //Console.WriteLine(myFirstTry);
            Console.WriteLine(mySecondTry);
            Console.ReadLine();

        }
    }
}
