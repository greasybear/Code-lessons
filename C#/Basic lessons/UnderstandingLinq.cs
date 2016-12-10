using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { Make="BMW", Model="550i", Color=CarColor.Blue, StickerPrice=55000, Year=2009 },
                new Car() { Make="Toyota", Model="4Runner", Color=CarColor.White, StickerPrice=35000, Year=2010 },
                new Car() { Make="BMW", Model="745li", Color=CarColor.Black, StickerPrice=75000, Year=2008 },
                new Car() { Make="Ford", Model="Escape", Color=CarColor.White, StickerPrice=28000, Year=2008 },
                new Car() { Make="BMW", Model="550i", Color=CarColor.Black, StickerPrice=57000, Year=2010 }
            };
            //var bmws = from car in myCars                     Creates anon data type that is created locally with on the fly assigned variables 
            //           where car.Make == "BMW"
            //           && car.Year == 2010
            //           select new { car.Make, car.Model, car.Year };

            //var orderedCars = from car in myCars
            //                  orderby car.Year descending
            //                  select car;

            // var _bmws = myCars.Where(p => p.Year == 2010).Where(p => p.Make == "BMW");   runing the where method twice, once to filter for only 2010 then again for BMW string

            //var _orderedCars = myCars.OrderByDescending(p => p.Year); // using lamba expression to order by descending but using year

            var sum = myCars.Sum(p => p.StickerPrice);


           // foreach (var car in sum)                   //the foreach value passed in will change based on which lamba expression is used above
                Console.WriteLine(sum);
            Console.ReadLine();


        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
        public CarColor Color { get; set; }
    }

    enum CarColor
    {
        White,
        Black,
        Red,
        Blue,
        Yellow
    }

}
