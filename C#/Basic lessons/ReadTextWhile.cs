using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadTextFileWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader myReader = new StreamReader("Values.txt");  //using the streamreader object to open up the values text file
            string line = "";   //declare an emtpy string called line                               

            while (line != null)     //iterates through as long as the line variable is not null-uknown or indeterminate value 
            {
                line = myReader.ReadLine();
                if (line != null)
                    Console.WriteLine(line);
            }

            myReader.Close();
            Console.ReadLine();

            
        }
    }
}
