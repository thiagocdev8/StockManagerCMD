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
        private int stockQuantity = 0;


        public PhysicalProduct() { }
        public PhysicalProduct(string name, float price, float deliveryFee)
        {
            this.name = name;
            this.price = price;
            this.deliveryFee = deliveryFee;
            stockQuantity++;
        }

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            Console.WriteLine($"Product Name: {name}\nPrice: {price}\nDelivery Fee: {deliveryFee}\nStock Quantity: {stockQuantity}\n");
            Console.WriteLine("====================");
        }

        public void RemoveProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
