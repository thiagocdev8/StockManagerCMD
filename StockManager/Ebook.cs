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
        private int stockQuantity = 0;

        public Ebook(string name, float price, string author)
        {
            this.name = name;
            this.price = price;
            this.author = author;
            stockQuantity++;
        }

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            Console.WriteLine($"Ebook Name: {name}\nPrice: {price}\nAuthor: {author}\nSales Quantity: {salesQuantity}\n");
        }

        public void RemoveProduct(Product product)
        {
            throw new NotImplementedException();
        }

       
    }
}
