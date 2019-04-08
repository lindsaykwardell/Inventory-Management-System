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
    public partial class PartForm : Form
    {
        public enum PartType { InHouse, Outsourced}

        public string NewName { get { return nameTextBox.Text; } }
        public int NewInStock { get { return int.Parse(inStockTextBox.Text); } }
        public double NewPrice { get { return Convert.ToDouble(priceTextBox.Text); } }
        public int NewMax { get { return int.Parse(maxTextBox.Text); } }
        public int NewMin { get { return int.Parse(minTextBox.Text); } }
        public string NewSpecial { get { return specialTextBox.Text; } }
        public PartType NewPartType { get { if (inHouseRadio.Checked) return PartType.InHouse; else return PartType.Outsourced; } }
        public PartForm()
        {
            InitializeComponent();
            partFormLabel.Text = "Add Part";
            this.Text = "Add Part";
        }

        public PartForm(Part partToModify)
        {
            InitializeComponent();
            partFormLabel.Text = "Modify Part";
            this.Text = "Modify Part";
            IDTextBox.Text = partToModify.GetPartID().ToString();
            nameTextBox.Text = partToModify.GetName();
            inStockTextBox.Text = partToModify.GetInStock().ToString();
            priceTextBox.Text = partToModify.GetPrice().ToString();
            maxTextBox.Text = partToModify.GetMax().ToString();
            minTextBox.Text = partToModify.GetMin().ToString();
            if (partToModify.GetType() == typeof(InHouse))
            {
                InHouse tempPart = partToModify as InHouse;
                inHouseRadio.Checked = true;
                specialLabel.Text = "Machine ID";
                specialTextBox.Text = tempPart.GetMachineID().ToString();
            } else
            {
                Outsourced tempPart = partToModify as Outsourced;
                outsourcedRadio.Checked = true;
                specialLabel.Text = "Company Name";
                specialTextBox.Text = tempPart.GetCompanyName();
            }
        }

        private void inHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            specialLabel.Text = "Machine ID";
            specialTextBox.Text = "";
        }

        private void outsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            specialLabel.Text = "Company Name";
            specialTextBox.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int test;
            if (nameTextBox.Text.Length <= 0)
            {
                MessageBox.Show("Name is required.");
                return;
            }
            if (!int.TryParse(inStockTextBox.Text, out test) || int.Parse(inStockTextBox.Text) < 0)
            {
                inStockTextBox.Text = "0";
            }
            if (!int.TryParse(priceTextBox.Text, out test) || int.Parse(priceTextBox.Text) < 0)
            {
                priceTextBox.Text = "0";
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
            if (NewPartType == PartType.InHouse)
            {
                if (!int.TryParse(specialTextBox.Text, out test))
                {
                    MessageBox.Show("Machine ID is required");
                    return;
                }
            } else
            {
                if (specialTextBox.Text.Length <= 0)
                {
                    specialTextBox.Text = "undefined";
                }
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
