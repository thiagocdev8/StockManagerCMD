using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager
{

    [Serializable]
    internal class Ebook : Product, IStock
    {
        public string author;
        private int salesQuantity;

        public Ebook() { }
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
            Console.WriteLine($"Ebook Name: {name}\nPrice: {price}\nAuthor: {author}\nSales Quantity: {salesQuantity}\n");
            Console.WriteLine("====================");
        }

        public void RemoveProduct(Product product)
        {
            throw new NotImplementedException();
        }

       
    }
}
