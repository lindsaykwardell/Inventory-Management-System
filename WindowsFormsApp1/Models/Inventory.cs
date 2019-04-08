using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class Inventory
    {
        private ArrayList products;
        private ArrayList allParts;

        public Inventory()
        {
            products = new ArrayList();
            allParts = new ArrayList();
        }

        public ArrayList GetProductList()
        {
            return products;
        }

        public ArrayList GetPartList()
        {
            return allParts;
        }

        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        public bool RemoveProduct(int productID)
        {
            foreach(Product product in products)
            {
                if (product.GetProductID() == productID)
                {
                    products.Remove(product);
                    return true;
                }
            }
            return false;
        }

        // Still not sure what to do here...
        // Returning new product again until
        // I know what I should do.
        public Product LookupProduct(int productID)
        {
            foreach(Product product in products)
            {
                if (product.GetProductID() == productID)
                {
                    return product;
                }
            }
            return new Product();
        }

        public void AddPart(Part part)
        {
            allParts.Add(part);
        }

        public bool RemovePart(int partID)
        {
            foreach (Part part in allParts)
            {
                if (part.GetPartID() == partID)
                {
                    allParts.Remove(part);
                    return true;
                }
            }
            return false;
        }

        public bool DeletePart(int partID)
        {
            foreach(Part part in allParts)
            {
                if (part.GetPartID() == partID)
                {
                    allParts.Remove(part);
                    return true;
                }
            }
            return false;
        }

        public Part LookupPart(int partID)
        {
            foreach(Part part in allParts)
            {
                if (part.GetPartID() == partID)
                {
                    return part;
                }
            }
            return null;
        }

        public void UpdatePart(int partID, Part newPart)
        {
            for (int i = 0; i < allParts.Count; i++)
            {
                Part part = allParts[i] as Part;
                if (part.GetPartID() == partID)
                {
                    allParts[i] = newPart;
                }
            }
        }
    }
}
