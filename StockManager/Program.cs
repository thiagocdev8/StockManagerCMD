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
            bool registerPhysicalProduct = false;

            while (!registerPhysicalProduct)
            {
                Console.WriteLine("\nRegistering a Physical Product...\n");
                Console.WriteLine("=================================");
                string productName;
                float productPrice;
                float deliveryFee;
                string input;
                string input2;
                do
                {
                    Console.WriteLine("\nProduct Name: ");
                    productName = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(productName))
                    {
                        Console.WriteLine("Product name cannot be empty. Please enter a valid name.");
                    }

                } while (string.IsNullOrWhiteSpace(productName));

                do
                {
                    Console.WriteLine("Enter the product price: ");
                    input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Input cannot be empty. Please enter a value.");
                        continue;
                    }

                    if (!float.TryParse(input, out productPrice))
                    {
                        Console.WriteLine("Invalid number. Please enter a valid float value (e.g., 12.34).");
                    }

                } while (string.IsNullOrWhiteSpace(input) || !float.TryParse(input, out productPrice));


                do
                {
                    Console.WriteLine("Enter Delivery Fee: ");
                    input2 = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Input cannot be empty. Please enter a value.");
                        continue;
                    }

                    if (!float.TryParse(input2, out deliveryFee))
                    {
                        Console.WriteLine("Invalid number. Please enter a valid float value (e.g., 12.34).");
                    }

                } while (string.IsNullOrWhiteSpace(input2) || !float.TryParse(input, out deliveryFee));



                Console.WriteLine("\nRegistering Physical Product:");
                Console.WriteLine($"Name: {productName}");
                Console.WriteLine($"Price: {productPrice}");
                Console.WriteLine($"Delivery Fee: {deliveryFee}\n");

                Console.WriteLine("\nDo you wish to confirm?");
                Console.WriteLine("1. Yes\n2. No");
                int confirm = int.Parse(Console.ReadLine());

                if (confirm == 1)
                {

                    productPrice = float.Parse(input);
                    deliveryFee = float.Parse(input2);

                    PhysicalProduct physicalProduct = new PhysicalProduct(productName, productPrice, deliveryFee);
                    products.Add(physicalProduct);
                    Save();
                    Console.WriteLine("Product registered successfully");
                    registerPhysicalProduct = true;
                }
                else if (confirm == 2)
                {
                    Console.WriteLine("Operation canceled.");
                    registerPhysicalProduct = true;
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            }
            
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
        static void RegisterEbook()
        {
            bool registerEbookProduct = false;

            while (!registerEbookProduct)
            {
                Console.WriteLine("Registering an eBook...");
                Console.WriteLine("=================================");
                string ebookName;
                float ebookPrice;
                string author;
                string input;
                do
                {
                    Console.WriteLine("eBook Name: ");
                    ebookName = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(ebookName))
                    {
                        Console.WriteLine("Product name cannot be empty. Please enter a valid name.");
                    }

                } while (string.IsNullOrWhiteSpace(ebookName));

                do
                {
                    Console.WriteLine("Enter eBook price: ");
                    input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Input cannot be empty. Please enter a value.");
                        continue;
                    }

                    if (!float.TryParse(input, out ebookPrice))
                    {
                        Console.WriteLine("Invalid number. Please enter a valid float value (e.g., 12.34).");
                    }

                } while (string.IsNullOrWhiteSpace(input) || !float.TryParse(input, out ebookPrice));

                do
                {
                    Console.WriteLine("Author: ");
                    author = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(author))
                    {
                        Console.WriteLine("Product name cannot be empty. Please enter a valid name.");
                    }

                } while (string.IsNullOrWhiteSpace(author));



                Console.WriteLine("\nRegistering eBook:");
                Console.WriteLine($"Name: {ebookName}");
                Console.WriteLine($"Price: {ebookPrice}");
                Console.WriteLine($"Author: {author}");

                Console.WriteLine("\nDo you wish to confirm?");
                Console.WriteLine("1. Yes\n2. No");
                int confirm = int.Parse(Console.ReadLine());

                if (confirm == 1)
                {

                    ebookPrice = float.Parse(input);

                    Ebook ebookProduct = new Ebook(ebookName, ebookPrice, author); // new object based on user info input
                    products.Add(ebookProduct); // adding new product object to the full products list 
                    Save();
                    Console.WriteLine("Product registered successfully");
                    registerEbookProduct = true;

                }
                else if (confirm == 2)
                {
                    Console.WriteLine("Operation canceled.");
                    registerEbookProduct = true;
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            }

            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
        static void RegisterOnlineCourse()
        {
            bool registerOnlineCourse = false;

            while (!registerOnlineCourse)
            {
                Console.WriteLine("Registering an Online Course...");
                Console.WriteLine("=================================");
                string courseName;
                float coursePrice;
                string instructor;
                string input;
                
                do
                {
                    Console.WriteLine("\nCourse Name: ");
                    courseName = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(courseName))
                    {
                        Console.WriteLine("Product name cannot be empty. Please enter a valid name.");
                    }

                } while (string.IsNullOrWhiteSpace(courseName));

                do
                {
                    Console.WriteLine("Enter the course price: ");
                    input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Input cannot be empty. Please enter a value.");
                        continue;
                    }

                    if (!float.TryParse(input, out coursePrice))
                    {
                        Console.WriteLine("Invalid number. Please enter a valid float value (e.g., 12.34).");
                    }

                } while (string.IsNullOrWhiteSpace(input) || !float.TryParse(input, out coursePrice));


                do
                {
                    Console.WriteLine("\nCourse Name: ");
                    instructor = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(instructor))
                    {
                        Console.WriteLine("Product name cannot be empty. Please enter a valid name.");
                    }

                } while (string.IsNullOrWhiteSpace(instructor));


                

                Console.WriteLine("\nRegistering Online Course:");
                Console.WriteLine($"Name: {courseName}");
                Console.WriteLine($"Price: {coursePrice}");
                Console.WriteLine($"instructor: {instructor}");
                Console.WriteLine("\nDo you wish to confirm?");
                Console.WriteLine("1. Yes\n2. No");
                int confirm = int.Parse(Console.ReadLine());

                if (confirm == 1)
                {

                    coursePrice = float.Parse(input);

                    OnlineCourse onlineCourseProduct = new OnlineCourse(courseName, coursePrice, instructor);
                    products.Add(onlineCourseProduct);
                    Save();
                    Console.WriteLine("Product registered successfully");
                    registerOnlineCourse = true;

                }
                else if (confirm == 2)
                {
                    Console.WriteLine("Operation canceled.");
                    registerOnlineCourse = true;
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            }
               
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