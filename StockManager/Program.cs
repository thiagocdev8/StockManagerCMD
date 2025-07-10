using System;
using System.Text;


namespace StockManager
{
    class Program
    {

        enum Menu 
        {   
            ListProducts = 1, 
            AddProduct = 2,
            RemoveProduct =3,
            StockEntry = 4,
            StockRemoval = 5,
            Exit = 6
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Stock Manager 8.0 developed by SolarX!");
            Console.WriteLine("This program is designed to help you manage your stock efficiently.");

            bool isRunning = false;

            while(!isRunning)
            {
                Console.WriteLine("\nPlease select an option from the menu below:");
                Console.WriteLine("1. List Products\n2. Add Products\n3. Remove Products\n4. Stock Entry\n5. Stock Removal\n6. Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case (int)Menu.ListProducts:
                        Console.WriteLine("Listing all products...");
                        // Logic to list products
                        break;
                    case (int)Menu.AddProduct:
                        Console.WriteLine("Adding a new product...");
                        // Logic to add a product
                        break;
                    case (int)Menu.RemoveProduct:
                        Console.WriteLine("Removing a product...");
                        // Logic to remove a product
                        break;
                    case (int)Menu.StockEntry:
                        Console.WriteLine("Entering stock for a product...");
                        // Logic for stock entry
                        break;
                    case (int)Menu.StockRemoval:
                        Console.WriteLine("Removing stock from a product...");
                        // Logic for stock removal
                        break;
                    case (int)Menu.Exit:
                        Console.WriteLine("Exiting the program. Thank you for using Stock Manager 8.0!");
                        isRunning = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }
}