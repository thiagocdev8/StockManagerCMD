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
        

        public Ebook() { }
        public Ebook(string name, float price, string author)
        {
            this.name = name;
            this.price = price;
            this.author = author;
        }

        public void AddProductToStock()
        {
            Console.WriteLine("This is a digital product. Stock is unlimited");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine($"Ebook Name: {name}\nPrice: {price}\nAuthor: {author}");
            Console.WriteLine("====================");
        }

        public void RemoveProductFromStock()
        {
            Console.WriteLine("This is a digital product. Stock is unlimited\n");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }
}
