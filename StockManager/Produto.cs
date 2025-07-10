using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager
{

    [Serializable]
    abstract class Product
    {
        public string name { get; set; }
        public float price { get; set; }

        protected Product() { }
    }
}
