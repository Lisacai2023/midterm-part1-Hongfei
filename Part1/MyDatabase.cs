using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_OOP_Midterm_Part1
{
    public static class MyDatabase
    {
        //static field
        private static List<Product> data;

        static MyDatabase()
        {
            Console.WriteLine("The list is loading");
            Clothing tShirt = new Clothing("T-shirt", 19.99, "Medium", "Red");
            Electronics smartphone = new Electronics("Smartphone", 799.99, "Apple");
            Groceries banana = new Groceries("Banana", 0.99, "2024-02-10");

            data.Add(tShirt);
            data.Add(smartphone);
            data.Add(banana);

        }
        // Static property
        public static List<Product> Data 
        {
            get { return data; }
        }



    }
}
