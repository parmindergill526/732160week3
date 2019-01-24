using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peterWeek3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle dog_and_cat = new Car();
            // Vehicle bowling = new Car();
            // Console.WriteLine("How many cars : {0}",Vehicle.howManyCars);
            // Console.ReadLine();
            Book myBook = new Book();
            myBook.SetTitle("A seperate peace");
            Console.WriteLine(myBook.GetTitle());
            Console.ReadLine();
        }
    }

    class Vehicle
    {
        public static int howManyCars = 0;
        public String Color = "Blue";
    }

    class Car : Vehicle
    {
        public String Color = "Red";
        public Car()
        {
            Vehicle.howManyCars++;
            Console.WriteLine("my color is " + Color);
            Console.ReadLine();
        }
    }
    class BookCollection
    {

    }
    class Book : BookCollection
    {
        private String Title;
        public void SetTitle(String aTitle) { this.Title = aTitle; }
        public String GetTitle() { return this.Title; }
    }
}
