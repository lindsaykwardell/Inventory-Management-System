using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class InventoryForm : Form
    {
        private Inventory currentInventory = new Inventory();
        private int nextProductID = 2000;
        private int nextPartID = 1000;
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void RenderProductsToTable()
        {
            productsTable.Rows.Clear();
            foreach (Product product in currentInventory.GetProductList())
            {
                productsTable.Rows.Add(product.GetProductID(), product.GetName(), product.GetInStock(), product.GetPrice());
            }
        }

        private void RenderProductToTable(Product product)
        {
            productsTable.Rows.Clear();
            productsTable.Rows.Add(product.GetProductID(), product.GetName(), product.GetInStock(), product.GetPrice());
        }

        private void RenderPartsToTable()
        {
            partsTable.Rows.Clear();
            foreach (Part part in currentInventory.GetPartList())
            {
                partsTable.Rows.Add(part.GetPartID(), part.GetName(), part.GetInStock(), part.GetPrice());
            }
        }

        private void RenderPartToTable(Part part)
        {
            partsTable.Rows.Clear();
            partsTable.Rows.Add(part.GetPartID(), part.GetName(), part.GetInStock(), part.GetPrice());
        }

        private void productSearchButton_Click(object sender, EventArgs e)
        {
            searchInventoryForProduct();   
        }

        private void productSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                searchInventoryForProduct();
        }

        private void searchInventoryForProduct()
        {
            int i;
            Int32.TryParse(productSearchBox.Text, out i);
            Product foundProduct = currentInventory.LookupProduct(i);
            if (foundProduct.GetProductID() > 0) RenderProductToTable(foundProduct);
            else
            {
                MessageBox.Show("No product found", "Product Not Found!");
                RenderProductsToTable();
            }
        }

        private void partSearchButton_Click(object sender, EventArgs e)
        {
            searchInventoryForPart();
        }

        private void searchInventoryForPart()
        {
            int i;
            Int32.TryParse(partSearchBox.Text, out i);
            Part foundPart = currentInventory.LookupPart(i);
            if (foundPart != null) RenderPartToTable(foundPart);
            else
            {
                MessageBox.Show("No part found", "Part Not Found!");
                RenderPartsToTable();
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            ProductForm addProductForm = new ProductForm(currentInventory.GetPartList());

            if (addProductForm.ShowDialog(this) == DialogResult.OK)
            {
                Product newProduct = new Product();
                newProduct.SetProductID(nextProductID);
                nextProductID++;
                newProduct.SetName(addProductForm.NewName);
                newProduct.SetInStock(addProductForm.NewInStock);
                newProduct.SetPrice(addProductForm.NewPrice);
                newProduct.SetMax(addProductForm.NewMax);
                newProduct.SetMin(addProductForm.NewMin);
                foreach (int part in addProductForm.partsList)
                {
                    newProduct.AddAssociatedPart(part);
                }
                currentInventory.AddProduct(newProduct);
                RenderProductsToTable();
            }
        }

        private void addPartButton_Click(object sender, EventArgs e)
        {
            PartForm addPartForm = new PartForm();
            if (addPartForm.ShowDialog(this) == DialogResult.OK)
            {
                if (addPartForm.NewPartType == PartForm.PartType.InHouse)
                {
                    InHouse newPart = new InHouse();
                    newPart.SetPartID(nextPartID);
                    nextPartID++;
                    newPart.SetName(addPartForm.NewName);
                    newPart.SetInStock(addPartForm.NewInStock);
                    newPart.SetPrice(addPartForm.NewPrice);
                    newPart.SetMax(addPartForm.NewMax);
                    newPart.SetMin(addPartForm.NewMin);
                    newPart.SetMachineID(int.Parse(addPartForm.NewSpecial));
                    currentInventory.AddPart(newPart);
                    RenderPartsToTable();
                } else
                {
                    Outsourced newPart = new Outsourced();
                    newPart.SetPartID(nextPartID);
                    nextPartID++;
                    newPart.SetName(addPartForm.NewName);
                    newPart.SetInStock(addPartForm.NewInStock);
                    newPart.SetPrice(addPartForm.NewPrice);
                    newPart.SetMax(addPartForm.NewMax);
                    newPart.SetMin(addPartForm.NewMin);
                    newPart.SetCompanyName(addPartForm.NewSpecial);
                    currentInventory.AddPart(newPart);
                    RenderPartsToTable();
                }
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            int index = productsTable.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = productsTable.Rows[index];
            int productID = int.Parse(Convert.ToString(selectedRow.Cells[0].Value));
            foreach(Product product in currentInventory.GetProductList())
            {
                if (product.GetProductID() == productID)
                {
                    ProductForm modifyProductForm = new ProductForm(currentInventory.GetPartList(), product);
                    if (modifyProductForm.ShowDialog(this) == DialogResult.OK)
                    {
                        product.SetName(modifyProductForm.NewName);
                        product.SetName(modifyProductForm.NewName);
                        product.SetInStock(modifyProductForm.NewInStock);
                        product.SetPrice(modifyProductForm.NewPrice);
                        product.SetMax(modifyProductForm.NewMax);
                        product.SetMin(modifyProductForm.NewMin);
                        product.ResetAssociatedParts();
                        foreach (int part in modifyProductForm.partsList)
                        {
                            product.AddAssociatedPart(part);
                        }
                        RenderProductsToTable();
                    }
                }
            }
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                int index = productsTable.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = productsTable.Rows[index];
                int productID = int.Parse(Convert.ToString(selectedRow.Cells[0].Value));
                foreach (Product product in currentInventory.GetProductList())
                {
                    if (product.GetProductID() == productID)
                    {
                        currentInventory.RemoveProduct(productID);
                        break;
                    }
                }
                RenderProductsToTable();
            }
        }

        private void deletePartButton_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                int index = partsTable.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = partsTable.Rows[index];
                int partID = int.Parse(Convert.ToString(selectedRow.Cells[0].Value));
                foreach (Part part in currentInventory.GetPartList())
                {
                    if (part.GetPartID() == partID)
                    {
                        currentInventory.RemovePart(partID);
                        foreach (Product product in currentInventory.GetProductList())
                        {
                            bool productsUseThisPart = true;
                            while (productsUseThisPart)
                            {
                                foreach (int associatedPartID in product.GetAssociatedParts())
                                {
                                    if (associatedPartID == partID)
                                    {
                                        product.RemoveAssociatedPart(partID);
                                        break;
                                    }
                                }
                                productsUseThisPart = false;
                            }
                        }
                        break;
                    }
                }
                RenderPartsToTable();
            }
        }

        private void modifyPartButton_Click(object sender, EventArgs e)
        {
            int index = partsTable.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = partsTable.Rows[index];
            int partID = int.Parse(Convert.ToString(selectedRow.Cells[0].Value));
            for (int i = 0; i < currentInventory.GetPartList().Count; i++)
            {
                Part part = currentInventory.GetPartList()[i] as Part;
                if (part.GetPartID() == partID)
                {
                    PartForm modifyPartForm = new PartForm(part);
                    if (modifyPartForm.ShowDialog(this) == DialogResult.OK)
                    {
                        if (modifyPartForm.NewPartType == PartForm.PartType.InHouse)
                        {
                            InHouse newPart = new InHouse();
                            newPart.SetPartID(partID);
                            newPart.SetName(modifyPartForm.NewName);
                            newPart.SetInStock(modifyPartForm.NewInStock);
                            newPart.SetPrice(modifyPartForm.NewPrice);
                            newPart.SetMax(modifyPartForm.NewMax);
                            newPart.SetMin(modifyPartForm.NewMin);
                            newPart.SetMachineID(int.Parse(modifyPartForm.NewSpecial));
                            currentInventory.UpdatePart(partID, newPart);

                            RenderPartsToTable();
                        }
                        else
                        {
                            Outsourced newPart = new Outsourced();
                            newPart.SetPartID(partID);
                            newPart.SetName(modifyPartForm.NewName);
                            newPart.SetInStock(modifyPartForm.NewInStock);
                            newPart.SetPrice(modifyPartForm.NewPrice);
                            newPart.SetMax(modifyPartForm.NewMax);
                            newPart.SetMin(modifyPartForm.NewMin);
                            newPart.SetCompanyName(modifyPartForm.NewSpecial);
                            currentInventory.UpdatePart(partID, newPart);

                            RenderPartsToTable();
                        }
                    }
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
