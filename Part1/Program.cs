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
            //Clothing tShirt = new Clothing("T-Shirt", 19.99, "Medium", "Red");
            //tShirt.DisplayProductInfo();
            Electronics smartphone = new Electronics("Smartphone", 799.99, "Apple");
            smartphone.DisplayProductInfo();


            List <Product> products = new List<Product>();
            //products.Add(tShirt); 
            products.Add(smartphone);
            products.Add(banana);

            Console.WriteLine("----- List of Product and display the list -----");

            foreach (Product product in products)
            {
                product.DisplayProductInfo();
            }



        }        
    }
}
