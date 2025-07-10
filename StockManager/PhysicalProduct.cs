using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager
{
    internal class PhysicalProduct : Product, IStock
    {
        public float deliveryFee;
        private int stockQuantity;

        public PhysicalProduct(string name, float price, float deliveryFee)
        {
            this.name = name;
            this.price = price;
            this.deliveryFee = deliveryFee;
    
        }

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void StockEntry(Product product, int quantity)
        {
            throw new NotImplementedException();
        }

        public void StockRemoval(Product product, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
