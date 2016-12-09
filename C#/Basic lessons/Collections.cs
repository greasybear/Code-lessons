using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car1 = new Car();
            //car1.Make = "Oldsmobile";
            //car1.Model = "Cutlass";

            //Car car2 = new Car();
            //car2.Make = "Geo";
            //car2.Model = "Prism";

            //Book b1 = new Book();
            //b1.Author = "Andrew Willis";
            //b1.Author = "Microsoft .NET XML Web Services";
            //b1.ISBN = "0-000-00000-0";

            //System.Collections.ArrayList myArraylist = new System.Collections.ArrayList();
            //myArraylist.Add(car1);
            //myArraylist.Add(car2);
            //myArraylist.Add(b1);
            //myArraylist.Remove(b1);

            //System.Collections.Specialized.ListDictionary myDictionary =
            //     new System.Collections.Specialized.ListDictionary();
            //myDictionary.Add(car1.Make, car1);
            //myDictionary.Add(car2.Make, car2);
            //myDictionary.Add(b1.Author, b1);



            //foreach (object o in myDictionary)
            //{
            //    //Console.WriteLine(((Car)o).Make);
            //    Console.WriteLine((()))
            //}

            //List<Car> myList = new List<Car >();

            //myList.Add(car1);
            //myList.Add(car2);

            //foreach (Car car in myList)
            //{ Console.WriteLine(car.Model); }

            //Console.ReadLine();

            //Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            //myDictionary.Add(car1.Make, car1);
            //myDictionary.Add(car2.Make, car2);

            //Console.WriteLine(myDictionary["Geo"].Model);

            //string[] name = { "Bob", "James", "Willis", "Chuck" };
            Car car1 = new Car() { Make = "Oldsmobile", Model = "Cutlass" };
            Car car2 = new Car() { Make = "Ford", Model = "F150" };
            Car car3 = new Car() { Make = "Honda", Model = "Accord" };

            List<Car> myList = new List<Car>()
            {
            new Car() { Make = "Oldsmobile", Model = "Cutlass" };
            new Car() { Make = "Ford", Model = "F150" };
            new Car() { Make = "Honda", Model = "Accord" };
        };

    }
    class Car
    {
        public string Model { get; set; }
        public string Make { get; set; }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }


}
