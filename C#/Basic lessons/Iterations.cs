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
            for (int i = 0; i < 10; i++) //This is saying that "i" starts at 0 and evertime it is less then 10, add 1. And Each time execute the below code
            {
                Console.WriteLine(i.ToString());   //this executes each time the for loop above is less than ten. 
                                                   //When it is no longer less than ten, we move to the next line of code
            }
            Console.ReadLine();
        } 
    }
}
