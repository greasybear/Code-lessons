using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

                int[] numbers = new int[6];  //square brackets are called index access operator, used to access specific elements of the array

                numbers[0] = 4;
                numbers[1] = 8;               //the commented out lines of code are a longer way of creating the array 
                numbers[2] = 15;
                numbers[3] = 16;
                numbers[4] = 23;
                numbers[5] = 42;
            // int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };             //here is an array created in which there is no need to define the number of values in the array

               Console.WriteLine(numbers[1].ToString());  //in this line we are retrieving the specific value we have in the array, accessing position 1 or the 2nd element
             Console.ReadLine();  
                                                                //this would print "8"
            //string[] names = new string[] { "Eddie", "Andrew", "Michael", "John" }; 

            //foreach (string name in names)          //this runs as: for each runs through the code block and executes, the writeLine, for each value in the array
            //{
            //    Console.WriteLine(name);                    
            //}
            //Console.ReadLine();

            string zig = "you can get what you want out of life" +                      //plus sign concatenate's the statement back together
                "if you help enough other people get what they want";
            char[] charArray = zig.ToCharArray();                                                   //converts the string to a Char(single character array)
            Array.Reverse(charArray);                                                       //reverses, makes first last and last first

            foreach (char zigChar in charArray)                                                 //for each, just write without separate lines
                Console.Write(zigChar);

            Console.ReadLine();

        }
    }
}
