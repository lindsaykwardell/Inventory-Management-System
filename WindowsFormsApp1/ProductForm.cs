using System;
using System.Collections;
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
    public partial class ProductForm : Form
    {
        public string NewName { get { return nameTextBox.Text; } }
        public int NewInStock { get { return int.Parse(inStockTextBox.Text); } }
        public double NewPrice { get { return Convert.ToDouble(priceTextBox.Text); } }
        public int NewMax { get { return int.Parse(maxTextBox.Text); } }
        public int NewMin { get { return int.Parse(minTextBox.Text); } }
        public ArrayList partsList;
        private ArrayList allPartsList;
        public ProductForm(ArrayList currentPartsList)
        {
            InitializeComponent();
            productFormLabel.Text = "Add Product";
            this.Text = "Add Product";
            InitializeData(currentPartsList);
        }

        public ProductForm(ArrayList currentPartsList, Product productToModify)
        {
            InitializeComponent();
            productFormLabel.Text = "Modify Product";
            this.Text = "Modify Product";
            InitializeData(currentPartsList);
            IDTextBox.Text = productToModify.GetProductID().ToString();
            nameTextBox.Text = productToModify.GetName();
            inStockTextBox.Text = productToModify.GetInStock().ToString();
            priceTextBox.Text = productToModify.GetPrice().ToString();
            maxTextBox.Text = productToModify.GetMax().ToString();
            minTextBox.Text = productToModify.GetMin().ToString();
            foreach(int part in productToModify.GetAssociatedParts())
            {
                partsList.Add(part);
            }
            RenderPartsList();
        }

        private void InitializeData(ArrayList currentPartsList)
        {
            allPartsList = currentPartsList;
            partsList = new ArrayList();
            RenderAllPartsList();
        }

        private void RenderAllPartsList()
        {
            allPartsTable.Rows.Clear();
            foreach (Part part in allPartsList)
            {
                allPartsTable.Rows.Add(part.GetPartID(), part.GetName(), part.GetInStock(), part.GetPrice());
            }
        }

        private void RenderQueriedPart(Part part)
        {
            allPartsTable.Rows.Clear();
            allPartsTable.Rows.Add(part.GetPartID(), part.GetName(), part.GetInStock(), part.GetPrice());
        }

        private void RenderPartsList()
        {
            partsTable.Rows.Clear();
            foreach (int partID in partsList)
            {
                foreach(Part part in allPartsList)
                {
                    if (part.GetPartID() == partID)
                    {
                        partsTable.Rows.Add(part.GetPartID(), part.GetName(), part.GetInStock(), part.GetPrice());
                    }
                }
            }
        }

        private void searchInventoryForPart()
        {
            int i;
            Int32.TryParse(partSearchBox.Text, out i);
            foreach (Part part in allPartsList)
            {
                if (part.GetPartID() == i)
                {
                    RenderQueriedPart(part);
                    return;
                }
            }
            
            MessageBox.Show("No part found", "Part Not Found!");
            RenderAllPartsList();
        }

        private void addPartButton_Click(object sender, EventArgs e)
        {
            int index = allPartsTable.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = allPartsTable.Rows[index];
            int partID = int.Parse(Convert.ToString(selectedRow.Cells[0].Value));
            partsList.Add(partID);
            RenderPartsList();
        }

        private void deletePartButton_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                int index = partsTable.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = partsTable.Rows[index];
                int partID = int.Parse(Convert.ToString(selectedRow.Cells[0].Value));
                foreach (int part in partsList)
                {
                    if (part == partID)
                    {
                        partsList.Remove(part);
                        break;
                    }
                }
                RenderPartsList();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int test;
            double priceTest;
            if (nameTextBox.Text.Length <= 0)
            {
                MessageBox.Show("Name is required.");
                return;
            }
            if (!int.TryParse(inStockTextBox.Text, out test) || int.Parse(inStockTextBox.Text) < 0)
            {
                inStockTextBox.Text = "0";
            }
            if (double.TryParse(priceTextBox.Text, out priceTest))
            {
                double minPrice = 0;
                foreach (int partID in partsList)
                {
                    foreach (Part part in allPartsList)
                    {
                        if (part.GetPartID() == partID)
                        {
                            minPrice += part.GetPrice();
                        }
                    }
                }
                if (minPrice > double.Parse(priceTextBox.Text))
                {
                    MessageBox.Show("Price cannot be less than the total price of parts.");
                    return;
                }
            } else
            {
                MessageBox.Show("Price is required.");
                return;
            }
            if (!int.TryParse(minTextBox.Text, out test))
            {
                MessageBox.Show("Minimum inventory level must be an integer.");
                return;
            }
            if (!int.TryParse(maxTextBox.Text, out test))
            {
                MessageBox.Show("Maxiumum inventory level must be an integer.");
                return;
            }
            if (int.Parse(maxTextBox.Text) <= int.Parse(minTextBox.Text))
            {
                MessageBox.Show("Maximum inventory level must be greater than minimum inventory level.");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to leave this page? Your changes won't be saved.", "Confirm Action", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void searchPartsButton_Click(object sender, EventArgs e)
        {
            searchInventoryForPart();
        }
    }
}
