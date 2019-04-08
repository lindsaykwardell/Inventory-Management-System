using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Part
    {
        private int partID;
        private string name;
        private double price;
        private int inStock;
        private int min;
        private int max;

        public void SetName(string newName)
        {
            name = newName;
        }

        public string GetName()
        {
            return name;
        }

        public void SetPrice(double newPrice)
        {
            price = newPrice;
        }

        public double GetPrice()
        {
            return price;
        }

        public void SetInStock(int newInStock)
        {
            inStock = newInStock;
        }

        public int GetInStock()
        {
            return inStock;
        }

        public void SetMin(int newMin)
        {
            min = newMin;
        }

        public int GetMin()
        {
            return min;
        }

        public void SetMax(int newMax)
        {
            max = newMax;
        }

        public int GetMax()
        {
            return max;
        }

        public void SetPartID(int newPartID)
        {
            partID = newPartID;
        }

        public int GetPartID()
        {
            return partID;
        }
    }
}
