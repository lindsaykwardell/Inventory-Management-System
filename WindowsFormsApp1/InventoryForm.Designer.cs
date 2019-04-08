namespace WindowsFormsApp1
{
    partial class InventoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainLabel = new System.Windows.Forms.Label();
            this.productsTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.productListLabel = new System.Windows.Forms.Label();
            this.productSearchBox = new System.Windows.Forms.TextBox();
            this.productSearchButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.modifyProduct = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.partListLabel = new System.Windows.Forms.Label();
            this.partSearchBox = new System.Windows.Forms.TextBox();
            this.partSearchButton = new System.Windows.Forms.Button();
            this.deletePartButton = new System.Windows.Forms.Button();
            this.modifyPartButton = new System.Windows.Forms.Button();
            this.addPartButton = new System.Windows.Forms.Button();
            this.partsTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitButton = new System.Windows.Forms.Button();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.mainLabel.Location = new System.Drawing.Point(24, 30);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(283, 25);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Inventory Management System";
            // 
            // productsTable
            // 
            this.productsTable.AllowUserToAddRows = false;
            this.productsTable.AllowUserToDeleteRows = false;
            this.productsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ProductNameColumn,
            this.inStock,
            this.price});
            this.productsTable.GridColor = System.Drawing.SystemColors.Window;
            this.productsTable.Location = new System.Drawing.Point(3, 59);
            this.productsTable.MultiSelect = false;
            this.productsTable.Name = "productsTable";
            this.productsTable.ReadOnly = true;
            this.productsTable.RowHeadersVisible = false;
            this.productsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsTable.Size = new System.Drawing.Size(514, 150);
            this.productsTable.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "Product ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.HeaderText = "Product Name";
            this.ProductNameColumn.Name = "ProductNameColumn";
            this.ProductNameColumn.ReadOnly = true;
            // 
            // inStock
            // 
            this.inStock.HeaderText = "Inventory Level";
            this.inStock.Name = "inStock";
            this.inStock.ReadOnly = true;
            this.inStock.Width = 120;
            // 
            // price
            // 
            this.price.HeaderText = "Price/Cost Per Item";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 140;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.productListLabel);
            this.panel1.Controls.Add(this.productSearchBox);
            this.panel1.Controls.Add(this.productSearchButton);
            this.panel1.Controls.Add(this.deleteProductButton);
            this.panel1.Controls.Add(this.modifyProduct);
            this.panel1.Controls.Add(this.addProductButton);
            this.panel1.Controls.Add(this.productsTable);
            this.panel1.Location = new System.Drawing.Point(585, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 290);
            this.panel1.TabIndex = 2;
            // 
            // productListLabel
            // 
            this.productListLabel.AutoSize = true;
            this.productListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productListLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.productListLabel.Location = new System.Drawing.Point(22, 21);
            this.productListLabel.Name = "productListLabel";
            this.productListLabel.Size = new System.Drawing.Size(89, 25);
            this.productListLabel.TabIndex = 4;
            this.productListLabel.Text = "Products";
            // 
            // productSearchBox
            // 
            this.productSearchBox.Location = new System.Drawing.Point(301, 21);
            this.productSearchBox.Name = "productSearchBox";
            this.productSearchBox.Size = new System.Drawing.Size(190, 20);
            this.productSearchBox.TabIndex = 6;
            this.productSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.productSearchBox_KeyDown);
            // 
            // productSearchButton
            // 
            this.productSearchButton.Location = new System.Drawing.Point(208, 18);
            this.productSearchButton.Name = "productSearchButton";
            this.productSearchButton.Size = new System.Drawing.Size(75, 23);
            this.productSearchButton.TabIndex = 5;
            this.productSearchButton.Text = "Search";
            this.productSearchButton.UseVisualStyleBackColor = true;
            this.productSearchButton.Click += new System.EventHandler(this.productSearchButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(331, 230);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(75, 23);
            this.deleteProductButton.TabIndex = 4;
            this.deleteProductButton.Text = "Delete";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // modifyProduct
            // 
            this.modifyProduct.Location = new System.Drawing.Point(208, 230);
            this.modifyProduct.Name = "modifyProduct";
            this.modifyProduct.Size = new System.Drawing.Size(75, 23);
            this.modifyProduct.TabIndex = 3;
            this.modifyProduct.Text = "Modify";
            this.modifyProduct.UseVisualStyleBackColor = true;
            this.modifyProduct.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(99, 230);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(75, 23);
            this.addProductButton.TabIndex = 2;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.partListLabel);
            this.panel2.Controls.Add(this.partSearchBox);
            this.panel2.Controls.Add(this.partSearchButton);
            this.panel2.Controls.Add(this.deletePartButton);
            this.panel2.Controls.Add(this.modifyPartButton);
            this.panel2.Controls.Add(this.addPartButton);
            this.panel2.Controls.Add(this.partsTable);
            this.panel2.Location = new System.Drawing.Point(29, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 290);
            this.panel2.TabIndex = 3;
            // 
            // partListLabel
            // 
            this.partListLabel.AutoSize = true;
            this.partListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partListLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.partListLabel.Location = new System.Drawing.Point(22, 21);
            this.partListLabel.Name = "partListLabel";
            this.partListLabel.Size = new System.Drawing.Size(57, 25);
            this.partListLabel.TabIndex = 7;
            this.partListLabel.Text = "Parts";
            // 
            // partSearchBox
            // 
            this.partSearchBox.Location = new System.Drawing.Point(301, 21);
            this.partSearchBox.Name = "partSearchBox";
            this.partSearchBox.Size = new System.Drawing.Size(190, 20);
            this.partSearchBox.TabIndex = 6;
            // 
            // partSearchButton
            // 
            this.partSearchButton.Location = new System.Drawing.Point(208, 18);
            this.partSearchButton.Name = "partSearchButton";
            this.partSearchButton.Size = new System.Drawing.Size(75, 23);
            this.partSearchButton.TabIndex = 5;
            this.partSearchButton.Text = "Search";
            this.partSearchButton.UseVisualStyleBackColor = true;
            this.partSearchButton.Click += new System.EventHandler(this.partSearchButton_Click);
            // 
            // deletePartButton
            // 
            this.deletePartButton.Location = new System.Drawing.Point(331, 230);
            this.deletePartButton.Name = "deletePartButton";
            this.deletePartButton.Size = new System.Drawing.Size(75, 23);
            this.deletePartButton.TabIndex = 4;
            this.deletePartButton.Text = "Delete";
            this.deletePartButton.UseVisualStyleBackColor = true;
            this.deletePartButton.Click += new System.EventHandler(this.deletePartButton_Click);
            // 
            // modifyPartButton
            // 
            this.modifyPartButton.Location = new System.Drawing.Point(208, 230);
            this.modifyPartButton.Name = "modifyPartButton";
            this.modifyPartButton.Size = new System.Drawing.Size(75, 23);
            this.modifyPartButton.TabIndex = 3;
            this.modifyPartButton.Text = "Modify";
            this.modifyPartButton.UseVisualStyleBackColor = true;
            this.modifyPartButton.Click += new System.EventHandler(this.modifyPartButton_Click);
            // 
            // addPartButton
            // 
            this.addPartButton.Location = new System.Drawing.Point(95, 230);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(75, 23);
            this.addPartButton.TabIndex = 2;
            this.addPartButton.Text = "Add";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.addPartButton_Click);
            // 
            // partsTable
            // 
            this.partsTable.AllowUserToAddRows = false;
            this.partsTable.AllowUserToDeleteRows = false;
            this.partsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.partsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.partsTable.GridColor = System.Drawing.SystemColors.Window;
            this.partsTable.Location = new System.Drawing.Point(3, 59);
            this.partsTable.MultiSelect = false;
            this.partsTable.Name = "partsTable";
            this.partsTable.ReadOnly = true;
            this.partsTable.RowHeadersVisible = false;
            this.partsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsTable.Size = new System.Drawing.Size(514, 150);
            this.partsTable.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Part ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Part Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Inventory Level";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Price/Cost Per Item";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 140;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1045, 415);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataSource = typeof(WindowsFormsApp1.Models.Inventory);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(WindowsFormsApp1.InventoryForm);
            // 
            // form1BindingSource1
            // 
            this.form1BindingSource1.DataSource = typeof(WindowsFormsApp1.InventoryForm);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1132, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainLabel);
            this.Name = "InventoryForm";
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource1;
        private System.Windows.Forms.DataGridView productsTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox productSearchBox;
        private System.Windows.Forms.Button productSearchButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button modifyProduct;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Label productListLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label partListLabel;
        private System.Windows.Forms.TextBox partSearchBox;
        private System.Windows.Forms.Button partSearchButton;
        private System.Windows.Forms.Button deletePartButton;
        private System.Windows.Forms.Button modifyPartButton;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.DataGridView partsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button exitButton;
    }
}

