using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager
{
    internal class OnlineCourse : Product
    {
        public string instructor;
        private int availableVacancies;

        public OnlineCourse(string name, float price, string instructor)
        {
            this.name = name;
            this.price = price;
            this.instructor = instructor;
        }
    }
    
    
}
