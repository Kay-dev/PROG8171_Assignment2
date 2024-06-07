using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8171_Assignment2
{
    internal class Product
    {
        public Product(int id, string name, double price, int stock)
        {
            ProductID = id;
            ProductName = name;
            Price = price;
            Stock = stock;
        }

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }


        public void IncreaseStock(int count)
        {
            Stock += count;
        }

        public void DecreaseStock(int count) 
        {
            Stock -= count; 
        }

    }
}
