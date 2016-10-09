using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;  //localized to US format 
            //Console.WriteLine(myValue.ToString()); //string format 
            //Console.WriteLine(myValue.ToShortDateString()); //string format(shorter, not time)
            //Console.WriteLine(myValue.ToShortTimeString()); //just time, sameAsAbove
            //Console.WriteLine(myValue.ToLongDateString()); //Longer format, justDate
            //Console.WriteLine(myValue.ToLongTimeString()); //this has seconds, format
            //Console.WriteLine(myValue.AddDays(3).ToLongDateString()); //this adds time to current
            //Console.WriteLine(myValue.AddHours(3).ToShortTimeString()); //this is both adding hours and changing format to string
            //Console.WriteLine(myValue.AddDays(-3).ToShortDateString()); //subtracting is add negative numbers
            //Console.WriteLine(myValue.Month.ToString());returns only number of month
            //DateTime myBirthday = new DateTime(1989, 12, 20); //prints out reversed, specifies value and datatype
            //Console.WriteLine(myBirthday.ToShortDateString()); //puts format to string
            DateTime myBirthday = DateTime.Parse("12/20/1989"); //setting literal string as value for myBirthday
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday); //stating that myAge is equal to now minus myBirthday
            Console.WriteLine(myAge.TotalDays); //method of writing the total number of days. 


            Console.ReadLine();
        }
    }
}
