using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager
{

    [Serializable]
    internal class OnlineCourse : Product, IStock
    {
        public string instructor {  get; set; }
        

        public OnlineCourse() { }
        public OnlineCourse(string name, float price, string instructor)
        {
            this.name = name;
            this.price = price;
            this.instructor = instructor;
        }

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            Console.WriteLine($"Course Name: {name}\nPrice: {price}\nInstructor: {instructor}");
            Console.WriteLine("====================");
        }

        public void RemoveProduct(Product product)
        {
            throw new NotImplementedException();
        }

        
    }
    
    
}
