using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager
{
    internal class Ebook : Product, IStock
    {
        public string author;
        private int salesQuantity;

        public Ebook(string name, float price, string author)
        {
            this.name = name;
            this.price = price;
            this.author = author;
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
