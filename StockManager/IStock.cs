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
        void AddProductToStock();
        void RemoveProductFromStock();
        

    }
}
