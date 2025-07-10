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

        public void Display()
        {
            Console.WriteLine($"Course Name: {name}\nPrice: {price}\nInstructor: {instructor}");
            Console.WriteLine("====================");
        }

        public void AddProductToStock()
        {
            Console.WriteLine("This is a digital product. Stock is unlimited\n");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }

        public void RemoveProductFromStock()
        {
            Console.WriteLine("This is a digital product. Stock is unlimited\n");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }
    
    
}
