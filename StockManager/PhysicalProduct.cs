using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager
{
    [Serializable]
    internal class PhysicalProduct : Product, IStock
    {
        public float deliveryFee { get; set; }

        [JsonProperty]
        private int stockQuantity { get; set; }


        public PhysicalProduct() { }
        public PhysicalProduct(string name, float price, float deliveryFee)
        {
            this.name = name;
            this.price = price;
            this.deliveryFee = deliveryFee;
            stockQuantity = 0;
        }

        public void AddProductToStock()
        {
            Console.WriteLine($"Entering stock for a product {name}.\n");
            Console.WriteLine("Enter amount of items to add to stock: ");
            int quantity = int.Parse(Console.ReadLine());

            stockQuantity += quantity;

            Console.WriteLine("\nStock entry registered\n");
            Console.WriteLine($"Total balance of {name}: {stockQuantity}");
        }

        public void Display()
        {
            Console.WriteLine($"Product Name: {name}\nPrice: {price}\nDelivery Fee: {deliveryFee}\nStock Quantity: {stockQuantity}\n");
            Console.WriteLine("====================");
        }

        public void RemoveProductFromStock()
        {
           
            Console.WriteLine("Enter the quantity of items to remove from stock: ");
            int quantity = int.Parse(Console.ReadLine());

            stockQuantity -= quantity;

            Console.WriteLine("\nRemoval registered\n");
            Console.WriteLine($"Total balance of {name}: {stockQuantity}");
        }

    }  
}
