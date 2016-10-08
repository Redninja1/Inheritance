using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            car myCar = new car();
            myCar.Make = "BMW";
            myCar.Model = "745li";
            myCar.colour = "Black";
            myCar.Year = 2005;

            truck myTruck = new truck();

            myTruck.Make = "Ford";
            myTruck.Model = "F950";
            myTruck.Year = 2006;
            myTruck.colour = "black";
            myTruck.towingCapacity = 1200;
            printCarDetails(myTruck);

                     
            printCarDetails(myCar);
            Console.ReadLine();

            

        }
        private static void printCarDetails(car car)
        {
            Console.WriteLine("Here are your car details: {0}",
            car.FormatMe());
        }
    }

    class car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string colour { get; set; }

        public string FormatMe()
        {


            return string.Format("{0} - {1} - {2} - {3}",
                this.Make,
                this.Model,
                this.colour,
                this.Year);
        }
    
    }

    class truck : car
    {
        public int towingCapacity { get; set; }
    }
}
