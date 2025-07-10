using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager
{
    internal interface IStock
    {
        void Display();
        void AddProduct(Product product);
        void RemoveProduct(Product product);
        void StockEntry(Product product, int quantity);
        void StockRemoval(Product product, int quantity);

    }
}
