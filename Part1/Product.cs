using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_OOP_Midterm_Part1
{
    public abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        //public string Brand { get; set; }

        public Product(string name, double price)
        {
            Name=name;
            Price=price;
        }

        //public virtual void DisplayProductInfo()
        //{
        //    Console.WriteLine("Producnt Information");
        //    Console.WriteLine($"Name : {Name}");
        //    Console.WriteLine($"Price : ${Price}");
        //    //    Console.WriteLine($"Size : {Size}");
        //    //    Console.WriteLine($"Color : {Color}");
        //    //    Console.WriteLine($"Brand : {Brand}");
        //    //    Console.WriteLine($"Expiry Date : {ExpiryDate}");
        //}

        public abstract void DisplayProductInfo();


    }
}
