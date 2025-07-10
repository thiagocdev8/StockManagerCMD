using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager
{
    internal class PhysicalProduct : Product
    {
        public float deliveryFee;
        private int stockQuantity;

        public PhysicalProduct(string name, float price, float deliveryFee)
        {
            this.name = name;
            this.price = price;
            this.deliveryFee = deliveryFee;
    
        }
    }
}
