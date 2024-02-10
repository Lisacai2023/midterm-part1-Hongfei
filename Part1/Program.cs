using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Xml.Serialization;

namespace Prog_OOP_Midterm_Part1
{
    //Midterm_Part1
    //Hongfei
    //02-06-2024
    internal class Program
    {
        static void Main()
        {
            List<string> myLocalList = new List<string>
            {
                "Item 1",
                "Item 2",
                "Item 3",
                "Item 4",
                "Item 5",
            };

            //Display or manipulate the local as needed
            foreach (string item in myLocalList)
            {
                Console.WriteLine(item);
            }

            //Access the static property to get the data
            List<Product> dataList = MyDatabase.Data;

            //Dispay the data from the static MyDatabase class
            foreach(Product product in dataList)
            {
                product.DisplayProductInfo();
            }

            //Product product = new Product("T-shirt", 19.99, "Medium", "Red", "", "");
            //product.DisplayProductInformation();

            Groceries banana = new Groceries("Banana", 0.99, "2024-02-15");
            banana.DisplayProductInfo();
            Clothing tShirt = new Clothing("T-Shirt", 19.99, "Medium", "Red");
            tShirt.DisplayProductInfo();
            Electronics smartphone = new Electronics("Smartphone", 799.99, "Apple");
            smartphone.DisplayProductInfo();


            List <Product> products = new List<Product>();
            products.Add(tShirt);
            products.Add(smartphone);
            products.Add(banana);

            Console.WriteLine("----- List of Product and display the list -----");

            foreach (Product product in products)
            {
                product.DisplayProductInfo();
            }

            //Using our updateConfig metho to change our connectio string. Make sure to pass in the correct information
            Config.UpdateConnectionString("CramberryFarms", "training", "Admin", "1234");

            //Saving the connectionString to a local variable
            string connectionString = Config.ConnectionString;
            Database db = Database.ConnectToDatabase(connectionString);

            List<Product> data = db.Data();

            //Saving a reference to an object in our list
            Product testGetType = data[0];

            //Display the type of the object
            Console.Write(testGetType.GetType());

            //Saving a local variable holding the type fo a specific object, here groceries
            Type groceryType = typeof(Groceries);

            //Comparing GetType to typeof(Groceries)
            bool sameType = testGetType.GetType() == groceryType;

            //Printing the result
            Console.WriteLine($"Are they the same time:{sameType}");

            Console.WriteLine("-------------Page4 Database connection-------------------");

            //foreach (Product d in data)
            //{
            //    d.DisplayProductInfo();
            //}

            bool exit = false;
            while(!exit)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("1. Display All Items");
                Console.WriteLine("2. Dislay Electronics");
                Console.WriteLine("3. Display Groceries");
                Console.WriteLine("4. Display Clothing");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayAllItems(data);
                        break;
                    case 2:
                        DisplayElectronics(data);
                        break;
                    case 3:
                        DisplayGroceries(data);
                        break;
                    case 4:
                        DisplayClothing(data);
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;


                }


            }

        }

        static void DisplayAllItems(List<Product> data)
        {
            foreach (Product product in data)
            {
                product.DisplayProductInfo();
            }
        }

        static void DisplayElectronics(List<Product> data)
        {
            foreach (Product product in data)
            {
                if (product.GetType() == typeof(Electronics))
                {
                    product.DisplayProductInfo();
                }
            }
        }

        static void DisplayGroceries(List<Product> data)
        {
            foreach (Product product in data)
            {
                product.DisplayProductInfo();
            }
        }

        static void DisplayClothing(List<Product> data)
        {
            foreach (Product product in data)
            {
                product.DisplayProductInfo();
            }
        }






    }




}
