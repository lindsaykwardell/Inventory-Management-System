using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Product
    {
        private ArrayList associatedParts;
        private int productID;
        private string name;
        private double price;
        private int inStock;
        private int min;
        private int max;

        public Product()
        {
            associatedParts = new ArrayList();
        }


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

        public void ResetAssociatedParts()
        {
            associatedParts.Clear();
        }

        public ArrayList GetAssociatedParts()
        {
            return associatedParts;
        }

        public void AddAssociatedPart(int part)
        {
            associatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int partID)
        {
            foreach(int part in associatedParts)
            {
                if (part == partID)
                {
                    associatedParts.Remove(part);
                    return true;
                }
            }
            return false;
        }

        public Part LookupAssociatedPart(int partID)
        {
            foreach(Part part in associatedParts)
            {
                if (part.GetPartID() == partID)
                {
                    return part;
                }
            }
            // Not sure what to do here...
            // UML clearly says to return a part,
            // but if no part is found, shouldn't 
            // I return false?
            // Returning blank part for now...
            return null;
        }

        public void SetProductID(int newProductID)
        {
            productID = newProductID;
        }

        public int GetProductID()
        {
            return productID;
        }
    }
}
