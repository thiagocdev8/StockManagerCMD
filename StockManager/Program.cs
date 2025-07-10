using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Newtonsoft.Json;


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

        static List<IStock> products = new List<IStock>();
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Stock Manager 8.0 developed by SolarX!");
            Console.WriteLine("This program is designed to help you manage your stock efficiently.");

            bool isRunning = false;

            Load();
            while (!isRunning)
            {
                Console.WriteLine("\nPlease select an option from the menu below:");
                Console.WriteLine("1. List Products\n2. Add Products\n3. Remove Products\n4. Stock Entry\n5. Stock Removal\n6. Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case (int)Menu.ListProducts:
                        Console.WriteLine("\nListing all products...");
                        ListProducts();
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        break;
                    case (int)Menu.AddProduct:

                        Console.WriteLine("\nAdding a new product...");
                        RegisterProduct();

                        break;
                    case (int)Menu.RemoveProduct:
                        Console.WriteLine("Removing a product...");
                        RemoveProduct();
                        // Logic to remove a product
                        break;
                    case (int)Menu.StockEntry:
                        Console.WriteLine("\nAdding stock..\n");
                        StockEntry();
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
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
                } Console.Clear();
            }
        }

        static void ListProducts()
        {
            if (products.Count > 0)
            {
                int id = 1;
                
                foreach (IStock product in products)
                {
                    Console.WriteLine($"ID : {id}");
                    product.Display();
                    id++;
                }
            }
            else
            {
                Console.WriteLine("\nNo Products registered in stock\n");
            }

            
        }
        static void RegisterProduct()
        {
            bool registerProductRunning = false;
            
            while (!registerProductRunning)
            {
                
                Console.WriteLine("\nChoose the type of product to register:");
                Console.WriteLine("1. Physical Product\n2. Ebook\n3. Online Course\n4. Return to main menu");

                int productType = int.Parse(Console.ReadLine());

                switch (productType)
                {
                    case 1:
                        RegisterPhysicalProduct(); // method that adds physical products to the stock list 
                        registerProductRunning = true;
                        break;
                    case 2:
                        RegisterEbook(); // method that adds ebooks to the product list
                        registerProductRunning = true;
                        break;
                    case 3:
                        RegisterOnlineCourse(); // method that adds online courses to the product list
                        registerProductRunning = true;
                        break;
                    case 4:
                        registerProductRunning = true;
                        break;
                    default:
                        Console.WriteLine("Invalid product type selected.");
                        continue;
                }
            }
            
        }
        static void RegisterPhysicalProduct()
        {
            Console.WriteLine("\nRegistering a Physical Product...\n");
            Console.WriteLine("=================================");
            Console.WriteLine("\nProduct Name: ");
            string productName = Console.ReadLine();
            Console.WriteLine("Product Price: ");
            float productPrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Product Delivery Fee: ");
            float deliveryFee = float.Parse(Console.ReadLine());

            

            Console.WriteLine("\nRegistering Physical Product:");
            Console.WriteLine($"Name: {productName}");
            Console.WriteLine($"Price: {productPrice}");
            Console.WriteLine($"Delivery Fee: {deliveryFee}\n");

            Console.WriteLine("Do you wish to confirm?");
            Console.WriteLine("1. Yes\n2. No");
            int confirm = int.Parse(Console.ReadLine());

                if (confirm == 1)
                {
                    PhysicalProduct physicalProduct = new PhysicalProduct(productName, productPrice, deliveryFee);
                    products.Add(physicalProduct);
                    Save();
                    Console.WriteLine("Product registered successfully");
                }
                else if (confirm == 2)
                {
                    Console.WriteLine("Operation canceled.");
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
        static void RegisterEbook()
        {
            Console.WriteLine("Registering an eBook...");
            Console.WriteLine("=================================");
            Console.WriteLine("eBook Name: ");
            string ebookName = Console.ReadLine();
            Console.WriteLine("eBook Price: ");
            float ebookPrice = float.Parse(Console.ReadLine());
            Console.WriteLine("eBook Author: ");
            string author = Console.ReadLine();

            Ebook ebookProduct = new Ebook(ebookName, ebookPrice, author); // new object based on user info input

            Console.WriteLine("Registering eBook:");
            Console.WriteLine($"Name: {ebookProduct.name}");
            Console.WriteLine($"Price: {ebookProduct.price}");
            Console.WriteLine($"Author: {ebookProduct.author}");

            products.Add(ebookProduct); // adding new product object to the full products list 
            Save();

            Console.WriteLine("Product registered successfully");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
        static void RegisterOnlineCourse()
        {
            Console.WriteLine("Registering an Online Course...");
            Console.WriteLine("=================================");
            Console.WriteLine("Course Name: ");
            string courseName = Console.ReadLine();
            Console.WriteLine("Product Price: ");
            float coursePrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Product Delivery Fee: ");
            string instructor = Console.ReadLine();

            OnlineCourse onlineCourseProduct = new OnlineCourse(courseName, coursePrice, instructor);

            Console.WriteLine("Registering Online Course:");
            Console.WriteLine($"Name: {onlineCourseProduct.name}");
            Console.WriteLine($"Price: {onlineCourseProduct.price}");
            Console.WriteLine($"instructor: {onlineCourseProduct.instructor}");

            products.Add(onlineCourseProduct);
            Save();

            Console.WriteLine("Product registered successfully");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
        static void RemoveProduct()
        {
            
            bool removingProduct = false;

            while (!removingProduct)
            {
                ListProducts();
                if (products.Count == 0)
                {
                    removingProduct = true;
                }
                else
                {
                    Console.WriteLine("Type the ID of the product you wish to delete.");

                    int id = int.Parse(Console.ReadLine());
                    if (id >= 0 && id <= products.Count)
                    {
                        Console.WriteLine($"Are you sure you wish to delete Product ID: {id}");
                        Console.WriteLine("1. Yes\n2. No");
                        int confirm = int.Parse(Console.ReadLine());

                        if (confirm == 1)
                        {
                            products.RemoveAt(id - 1);
                            Save();
                            Console.WriteLine("Product has been deleted.");
                            removingProduct = true;
                        }
                        else if (confirm == 2)
                        {
                            Console.WriteLine("Operation canceled.");
                            removingProduct = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid option");
                            break;
                        }
                    } 
                    else
                    {
                        Console.WriteLine("Please type a valid option.");
                    }
                }
                    
            }

                
        }

        static void StockEntry()
        {
            bool addingStock = false;

            while (!addingStock)
            {
                
                if (products.Count == 0)
                {
                    ListProducts();
                    addingStock = true;
                }
                else
                {
                    Console.WriteLine("Type the ID of the product you wish to add stock.\n");
                    ListProducts();

                    int id = int.Parse(Console.ReadLine());
                    if (id >= 0 && id <= products.Count)
                    {
                        Console.WriteLine($"Are you sure you wish to update Product ID: {id}");
                        Console.WriteLine("1. Yes\n2. No");
                        int confirm = int.Parse(Console.ReadLine());

                        if (confirm == 1)
                        {
                            IStock product = products[id - 1];
                            product.AddProductToStock();
                            Save();

                            string productName = "";
                            if (product is PhysicalProduct physProd)
                                productName = physProd.name;
                            else if (product is Ebook ebookProd)
                                productName = ebookProd.name;
                            else if (product is OnlineCourse courseProd)
                                productName = courseProd.name;

                            Console.WriteLine($"Product: {productName} stock updated.\n");
                            addingStock = true;
                        }
                        else if (confirm == 2)
                        {
                            Console.WriteLine("Operation canceled.");
                            addingStock = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid option");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please type a valid option.");
                    }
                }

            }
        }
        static void Save()
        {
            try
            {
                var settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All,
                    Formatting = Formatting.Indented
                };

                string json = JsonConvert.SerializeObject(products, settings);
                File.WriteAllText("products.json", json);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving products: {ex.Message}");
            }
        }
        static void Load()
        {
            try
            {
                if (File.Exists("products.json"))
                {
                    var settings = new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.All
                    };

                    string json = File.ReadAllText("products.json");

                    products = JsonConvert.DeserializeObject<List<IStock>>(json, settings);  
                } 
                else 
                {
                    products = new List<IStock>();
                }
               
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading products: {ex.Message}");
            }
        }

    }

}