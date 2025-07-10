using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager
{
    internal class OnlineCourse : Product, IStock
    {
        public string instructor;
        private int availableVacancies;

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
            Console.WriteLine($"Course Name: {name}\nPrice: {price}\nInstructor: {instructor}\nAvailable Vacancies: {availableVacancies}\n");
        }

        public void RemoveProduct(Product product)
        {
            throw new NotImplementedException();
        }

        
    }
    
    
}
